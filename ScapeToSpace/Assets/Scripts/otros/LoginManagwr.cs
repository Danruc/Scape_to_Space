using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoginManagwr : MonoBehaviour
{
    public InputField usrField;
    //public InputField pwdField;
    public InputField registerUser;
    public InputField registerEmail;
    public TMPro.TMP_InputField registerPassword;
    public TMPro.TMP_InputField registerConfirmPwd;
    //public TMPro.TMP_InputField usrField;
    public TMPro.TMP_InputField pwdField;

    IEnumerator SendData(string json)
    {
        WWWForm form = new WWWForm();
        form.AddField("bundle", "json");
        string url = "http://localhost:8080";

        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
            www.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
            www.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
            www.SetRequestHeader("Content-Type", "application/json");

            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                Session s = JsonUtility.FromJson<Session>
                    (www.downloadHandler.text.Replace('\'', '\"'));
                Debug.Log(s);
            }
        }
    }

    public string Md5Sum(string input) //Ya existe en MySQL el Md5
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(input);
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        string hashed = "";
        foreach (byte b in hashBytes)
        {
            hashed += System.Convert.ToString(b, 16).PadLeft(2, '0');
        }

        return hashed.PadLeft(32, '0');
    }

    public void VerifyUserData() /* Asignar al botón */
    {
        string md5 = Md5Sum(pwdField.text);
        string usr = usrField.text;
        //Debug.Log(usr);
        //Debug.Log(md5);
        //{usr: ###, data_b: ### } no es buena idea poner "pwd" o parecidos
        string jsonTxt = "{\"data_a\" : \"" + usr + "\", \"data_b\" : \"" + md5 + "\"}";
        Debug.Log(jsonTxt);
        StartCoroutine(SendData(jsonTxt));
        GameObject sessionDataGO = GameObject.Find("GameController");
        SessionData sd = sessionDataGO.GetComponent<SessionData>();
        sd.name = usrField.text;
    }
    public void RegisterUserData()
    {
        string md5 = Md5Sum(registerPassword.text);
        string usr = registerUser.text;
        string email = registerEmail.text;
        //Debug.Log(usr);
        //Debug.Log(md5);
        //{usr: ###, data_b: ### } no es buena idea poner "pwd" o parecidos
        string jsonTxt = "{\"data_a\" : \"" + usr + "\", \"data_b\" : \"" + md5 + "\", \"data_c\" : \"" + email + "\"}";
        Debug.Log(jsonTxt);
        //StartCoroutine(SendData(jsonTxt));
        SendData(jsonTxt);
        GameObject sessionDataGO = GameObject.Find("GameController");
        SessionData sd = sessionDataGO.GetComponent<SessionData>();
        sd.name = registerUser.text;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

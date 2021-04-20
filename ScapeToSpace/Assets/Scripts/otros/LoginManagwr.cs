using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManagwr : MonoBehaviour
{
    public InputField usrField;
    //public InputField pwdField;
    //public TMPro.TMP_InputField usrField;
    public TMPro.TMP_InputField pwdField;
    public GameObject failedLogin;
    IEnumerator SendData(string json)
    {
        WWWForm form = new WWWForm();
        form.AddField("bundle", "json");
        string url = "http://104.210.213.204:8000/unity";

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
                bool b = www.downloadHandler.text.Contains("Login is: \": \"Welcome!");
                ChangeLoginStatus(b);
                //Session s = JsonUtility.FromJson<Session>
                    //(www.downloadHandler.text.Replace('\'', '\"'));
                //Debug.Log(s);
            
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
        string md5 = pwdField.text;
        string usr = usrField.text;
        //Debug.Log(usr);
        //Debug.Log(md5);
        //{usr: ###, data_b: ### } no es buena idea poner "pwd" o parecidos
        string jsonTxt = "{\"data_a\" : \"" + usr + "\", \"data_b\" : \"" + md5 + "\"}";
        Debug.Log(jsonTxt);
        StartCoroutine(SendData(jsonTxt));
        GameObject sessionDataGO = GameObject.Find("GameControllerData");
        //SessionData sd = sessionDataGO.GetComponent<SessionData>();
        User u = sessionDataGO.AddComponent<User>();
        u.setInfo(usr, md5);
        //sd.name = usrField.text;
    }

    public void ChangeLoginStatus(bool b)
    {
        Debug.Log(b);

        if (b)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            failedLogin.active = true;

        }

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

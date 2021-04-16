using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

[Serializable] // Para subir los datos a internet, solo datos simples

public class WebClient : MonoBehaviour
{
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
                //User aUser = JsonUtility.FromJson<User>(www.downloadHandler.text);
                Debug.Log("Form upload complete");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        User usuario = new User(1, "Ag123", "password", "67-09-890", 1, "toro@gmail.com");

        string json = JsonUtility.ToJson(usuario);
        Debug.Log(json);

        //TextAsset list = Resources.Load<TextAsset>("Text/AssetBundleInfo");
        //string json = EditorJsonUtility.ToJson(list);
        //Debug.Log(list.ToString());
        StartCoroutine(SendData(json));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

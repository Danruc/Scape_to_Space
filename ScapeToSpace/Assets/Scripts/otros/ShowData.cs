using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    void Start()
    {
        GameObject label = GameObject.Find("WelcomeText");
        Text labelText = label.GetComponent<Text>();
        GameObject sessionDataGO = GameObject.Find("GameControllerData");
        //SessionData sd = sessionDataGO.GetComponent<SessionData>();
        
        //labelText.text = "Bienvenido/a " + sd.name;

        User u = sessionDataGO.GetComponent<User>();
        labelText.text = "Bienvenido/a " + u.getName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

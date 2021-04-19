using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CerrarInstrucciones : MonoBehaviour
{
    public GameObject popup;
    public GameObject prender;




    public void click()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        popup.active = !popup.active;
        
        CountDownq1.conteo.Empezar();

        prender.active = !prender.active;

    }
    
}

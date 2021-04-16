using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CerrarInstrucciones : MonoBehaviour
{
    public GameObject popup;

    
    
    public void click()
    {
        popup.active = !popup.active;
        CountDownq1.conteo.Empezar();
    }
    
}

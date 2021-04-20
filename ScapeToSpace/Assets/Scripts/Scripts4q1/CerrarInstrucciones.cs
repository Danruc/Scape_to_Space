using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CerrarInstrucciones : MonoBehaviour
{
    public GameObject popup;
<<<<<<< HEAD
    public GameObject prender;




    public void click()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        popup.active = !popup.active;
        
        CountDownq1.conteo.Empezar();

        prender.active = !prender.active;

=======

    
    
    public void click()
    {
        popup.active = !popup.active;
        CountDownq1.conteo.Empezar();
>>>>>>> main
    }
    
}

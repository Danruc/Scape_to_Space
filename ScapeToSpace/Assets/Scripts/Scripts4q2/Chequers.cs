using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chequers : MonoBehaviour
{
    private GameObject botonchecar;
    private BotonChecar boton;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "izquierda" && gameObject.tag == "Resizquierda")
        {
            boton.tank1 = true;
            Debug.Log("check");
        }else if(collision.gameObject.tag == "izquierda" && gameObject.tag == "Reizquierda2")
        {
            boton.tank2 = true;
            Debug.Log("check");
        }
        else if (collision.gameObject.tag == "arriba" && gameObject.tag == "Resarriba")
        {
            boton.tank3 = true;
            Debug.Log("check");
        }
        else
        {
            //collision.gameObject.active = false;
        }
    }

    void Start()
    {
        botonchecar = GameObject.Find("Checar");
        boton = botonchecar.GetComponent<BotonChecar>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonSalir : MonoBehaviour
{
    public GameObject salida;
    // Start is called before the first frame update
    public void Click()
    {
        FindObjectOfType<AudioManager>().Play("Check");
        salida.active = !salida.active;
    }
}

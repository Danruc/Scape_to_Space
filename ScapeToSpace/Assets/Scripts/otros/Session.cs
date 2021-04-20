using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TimeController.instance.BeginTimer();
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}

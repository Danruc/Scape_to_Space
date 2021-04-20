using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tank3 : MonoBehaviour
{
    public Toggle tag;
    public HealthBar seis;

    public void togg(bool bo)
    {
        if (bo)
        {
            BotonChecar.instance.tank3 = true;
            seis.SetHealth(10);
            

        }
        else
        {
            BotonChecar.instance.tank3 = false;
            seis.SetHealth(0);
            
        }

    }
    void Start()
    {
        seis.SetMaxhealth(10);
        
    }
}

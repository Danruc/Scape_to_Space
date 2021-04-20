using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tank1 : MonoBehaviour
{
    public Toggle tag;
    public HealthBar uno;

    public void togg(bool bo)
    {
        if (bo) {
            BotonChecar.instance.tank1 = true;
            uno.SetHealth(10);
        }
        else
        {
            BotonChecar.instance.tank1 = false;
            uno.SetHealth(0);
        }
        
    }
    void Start()
    {
        uno.SetMaxhealth(10);
    }

    
}

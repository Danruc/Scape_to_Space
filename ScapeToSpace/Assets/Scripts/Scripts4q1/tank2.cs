using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tank2 : MonoBehaviour
{
    public Toggle tag;
    public HealthBar tres, cinco, cuatro, veinticuatro;

    public void togg(bool bo)
    {
        if (bo)
        {
            BotonChecar.instance.tank2 = true;
            cinco.SetHealth(10);
            cuatro.SetHealth(10);
            veinticuatro.SetHealth(10);
            tres.SetHealth(10);
            
        }
        else
        {
            BotonChecar.instance.tank2 = false;
            cinco.SetHealth(0);
            cuatro.SetHealth(0);
            veinticuatro.SetHealth(0);
            tres.SetHealth(0);
            
        }

    }
    void Start()
    {
        tres.SetMaxhealth(10);
        cinco.SetMaxhealth(10);
        cuatro.SetMaxhealth(10);
        veinticuatro.SetMaxhealth(10);
    }
}

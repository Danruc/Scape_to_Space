using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonChecar : MonoBehaviour
{
    public static BotonChecar instance;
    public static bool quest;
    public HealthBar bar;
    public Text intentos;
    public Text puntaje;
    public GameObject terminal;
   
    public static int x = 0;
    public static int score = 1000;
    public bool tank1;
    public bool tank2;
    public bool tank3;

    private int y = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (quest)
        {
            bar.SetMaxhealth(5);
        }
        
        instance = this;
        tank1 = false;
        tank2 = false;
        tank3 = false;
    }

   
    public void Click()
    {
        if (quest)
        {
            x++;
            intentos.text = "Intentos: " + x;



            if (tank1 && tank2 && tank3)
            {
                FindObjectOfType<AudioManager>().Play("yey");
                while (y < 6)
                {
                    bar.SetHealth(y);
                    new WaitForSeconds(1f);
                    y++;
                }


                terminal.active = !terminal.active;
                tank1 = false;
                tank2 = false;
                tank3 = false;

            }
            else
            {
                FindObjectOfType<AudioManager>().Play("fail");
                score -= 100;
                puntaje.text = "Score: " + score;

            }
        }
        else
        {
            
            x++;
            intentos.text = "Intentos: " + x;
            


            if (tank1 && tank2 && tank3)
            {
                FindObjectOfType<AudioManager>().Play("yey");
             
                terminal.active = !terminal.active;

            }
            else
            {
                GameObject[] botonchecarI = GameObject.FindGameObjectsWithTag("izquierda");
                for (int i = 0; i <botonchecarI.Length; i++)
                {
                    botonchecarI[i].active = false;
                }
                GameObject[] botonchecarR = GameObject.FindGameObjectsWithTag("derecha");
                for (int i = 0; i < botonchecarR.Length; i++)
                {
                    botonchecarR[i].active = false;
                }
                GameObject[] botonchecarA = GameObject.FindGameObjectsWithTag("arriba");
                for (int i = 0; i < botonchecarA.Length; i++)
                {
                    botonchecarA[i].active = false;
                }
                GameObject[] botonchecarAB = GameObject.FindGameObjectsWithTag("abajo");
                for (int i = 0; i < botonchecarAB.Length; i++)
                {
                    botonchecarAB[i].active = false;
                }
                FindObjectOfType<AudioManager>().Play("fail");
                score -= 100;
                puntaje.text = "Score: " + score;

            }
        }
    }
        

    
}





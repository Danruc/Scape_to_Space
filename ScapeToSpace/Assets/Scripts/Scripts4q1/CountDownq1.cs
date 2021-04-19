using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownq1 : MonoBehaviour
{
    public static CountDownq1 conteo;
    public int countdown;
    public Text countdowndisplay;


    private void Start()
    {
        
    }

    private void Awake()
    {
        conteo = this;
    }

    public void Empezar()
    {
        StartCoroutine(CountDownToStart());
    }
    IEnumerator CountDownToStart()
    {
        countdowndisplay.gameObject.SetActive(true);
        while (countdown > 0)
        {
            countdowndisplay.text = countdown.ToString();

            yield return new WaitForSeconds(1f);

            countdown--;
        }

        countdowndisplay.text = "¡Vamos!";

        yield return new WaitForSeconds(1f);

        countdowndisplay.gameObject.SetActive(false);

        Quest1TimerController.obj.BeginTimer();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeController : MonoBehaviour
{
    public static TimeController instance;
    public Text Tiempo;

    private TimeSpan timecounter;
    private bool timergoing;
    private float elapsedtime;

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        Tiempo.text = "Tiempo: 00:00.00";
        timergoing = false;
    }

    public void BeginTimer()
    {
        timergoing = true;
        elapsedtime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timergoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timergoing)
        {
            elapsedtime += Time.deltaTime;
            timecounter = TimeSpan.FromSeconds(elapsedtime);
            string TimePlayingstr = "Tiempo: " + timecounter.ToString("mm':'ss'.'ff");
            Tiempo.text = TimePlayingstr;

            yield return null;
        }
    }

}

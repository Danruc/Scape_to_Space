using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class Quest1TimerController : MonoBehaviour
{
    // Start is called before the first frame update
    public static Quest1TimerController obj;
    public Text timecounter;

    private TimeSpan TimePlaying;
    private bool timerGoing;
    float elapsedtime;

    private void Awake()
    {
        obj = this;
    }

    private void Start()
    {
        timecounter.text = "Tiempo: 00:00.00";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedtime = 0f;

        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedtime += Time.deltaTime;
            TimePlaying = TimeSpan.FromSeconds(elapsedtime);
            string timePlayigString = "Tiempo: " + TimePlaying.ToString("mm':'ss'.'ff");
            timecounter.text = timePlayigString;

            yield return null;
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

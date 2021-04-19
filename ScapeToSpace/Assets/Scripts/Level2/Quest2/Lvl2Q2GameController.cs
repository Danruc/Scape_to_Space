using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl2Q2GameController : MonoBehaviour
{
    public Text timerText;
    //public Text scoreText;
    private float time = 0;
    public GameObject backgroundInstructions;
    public GameObject startQuestButton;
    public GameObject descriptionLabel;
    //public GameObject finalScore;
    void Start()
    {
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        startQuestButton.active = false;
        backgroundInstructions.active = false;
        descriptionLabel.active = false;
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        //if (time < 0)
        //{
            //Time.timeScale = 0;
            //timerText.text = "0:00";
            //backgroundInstructions.active = true;

            //Text finalScoreText = finalScore.GetComponent<Text>();
            //finalScoreText.text = "Puntos por minerales (" + mineralesTotales.ToString() + "): " + score.ToString() + "\n" + "Puntos por plataformas (" + platformsNumber.ToString() + "): " + platformsPoints.ToString() + "\n" + "Puntuación final: " + finalScoreNumber.ToString();
            //finalScore.active = true;
        //}
    }
}

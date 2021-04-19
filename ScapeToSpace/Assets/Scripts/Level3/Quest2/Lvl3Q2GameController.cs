using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl3Q2GameController : MonoBehaviour
{
    public Transform[] mineralSpawns;
    public GameObject Mineral;
    public Transform[] siloSpawns;
    public GameObject Silo;
    public Text timerText;
    public Text scoreText;
    private float TimeRemaining = 120;
    private float timeToSpawn = 1.5f;
    private int numAleatorioM;
    private bool locked90 = false;
    private bool locked60 = false;
    private bool locked30 = false;
    private GameObject siloSpawned;
    public int score = 0;
    public int platformsNumber = 0;
    public GameObject backgroundInstructions;
    public GameObject startQuestButton;
    public GameObject descriptionLabel;
    public GameObject finalScore;
    public GameObject npv;
    public GameObject nph;
    public GameObject npr;
    public GameObject npl;
    // Start is called before the first frame update
    void Start()
    {
        siloSpawned = Instantiate(Silo);
        int numAleatorio = Random.Range(0, siloSpawns.Length);
        siloSpawned.transform.position = siloSpawns[numAleatorio].position;

        numAleatorioM = Random.Range(0, mineralSpawns.Length);
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        npv.active = true;
        nph.active = true;
        npr.active = true;
        npl.active = true;
        startQuestButton.active = false;
        backgroundInstructions.active = false;
        descriptionLabel.active = false;
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        TimeRemaining -= Time.deltaTime;
        timeToSpawn += Time.deltaTime;
        float minutes = Mathf.FloorToInt(TimeRemaining / 60);
        float seconds = Mathf.FloorToInt(TimeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (seconds % 3 == 0 && timeToSpawn >= 1.5) {
            GameObject mineralSpawned = Instantiate(Mineral);
            mineralSpawned.transform.position = mineralSpawns[numAleatorioM].position;
            timeToSpawn = 0;
        }
        if (TimeRemaining < 90 && locked90 == false)
        {
            numAleatorioM = Random.Range(0, mineralSpawns.Length);
            int numAleatorio = Random.Range(0, siloSpawns.Length);
            siloSpawned.transform.position = siloSpawns[numAleatorio].position;
            locked90 = true;
        }
        if (TimeRemaining < 60 && locked60 == false)
        {
            numAleatorioM = Random.Range(0, mineralSpawns.Length);
            int numAleatorio = Random.Range(0, siloSpawns.Length);
            siloSpawned.transform.position = siloSpawns[numAleatorio].position;
            locked60 = true;
        }
        if (TimeRemaining < 30 && locked30 == false)
        {
            numAleatorioM = Random.Range(0, mineralSpawns.Length);
            int numAleatorio = Random.Range(0, siloSpawns.Length);
            siloSpawned.transform.position = siloSpawns[numAleatorio].position;
            locked30 = true;
        }
        if (TimeRemaining < 0)
        {
            Time.timeScale = 0;
            timerText.text = "0:00";
            backgroundInstructions.active = true;
            int mineralesTotales = score / 100;
            int platformsPoints;
            if (platformsNumber <= 2 && platformsNumber >= 1)
            {
                platformsPoints = 2000;
            }else if (platformsNumber <= 4 && platformsNumber >= 3)
            {
                platformsPoints = 1500;
            }
            else if (platformsNumber <= 6 && platformsNumber >= 5)
            {
                platformsPoints = 1000;
            }else if (platformsNumber >= 7)
            {
                platformsPoints = 500;
            }
            else
            {
                platformsPoints = 0;
            }
            int finalScoreNumber = score + platformsPoints;
            Text finalScoreText = finalScore.GetComponent<Text>();
            finalScoreText.text = "Puntos por minerales (" + mineralesTotales.ToString() + "): " + score.ToString() + "\n"+ "Puntos por plataformas (" + platformsNumber.ToString() + "): " + platformsPoints.ToString() + "\n" + "Puntuación final: " + finalScoreNumber.ToString();
            finalScore.active = true;
            npv.active = false;
            nph.active = false;
            npr.active = false;
            npl.active = false;
        }

    }
}

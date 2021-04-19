using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionData : MonoBehaviour
{
    public string name;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class User : MonoBehaviour
{
    private string Username;
    private string Password;

    public User(string _username, string _password)
    {
        Username = _username;
        Password = _password;
    }
    public void setInfo(string _username, string _password)
    {
        Username = _username;
        Password = _password;
    }
    public string getName()
    {
        return Username;
    }
}

public class Session : MonoBehaviour
{
    private int id;
    private int userID ;
    private string timeStart;
    private string finalTime;
    private int finalScore;
    private bool finishGame;

    public Session(int _id, int _userID, string _timeStart, string _finalTime, int _finalScore, bool _finishGame)
    {
        id = _id;
        userID = _userID;
        timeStart = _timeStart;
        finalTime = _finalTime;
        finalScore = _finalScore;
        finishGame = _finishGame;
    }
    public void setInfo( int _id ,int _userID,string _timeStart,string _finalTime,int _finalScore, bool _finishGame)
    {
        id = _id;
        userID= _userID;
        timeStart= _timeStart;
        finalTime =_finalTime;
        finalScore= _finalScore;
        finishGame = _finishGame;
    }
}
public class Level : MonoBehaviour
{
    private string levelTime;
    private int levelScore;
    private int levelNumber;
    private bool clear;
    private int tries;
    private int sessionID;

    public Level(string _levelTime,int _levelScore,int _levelNumber,bool _clear,int _tries,int _sessionID)
    {
        levelTime = _levelTime;
        levelScore = _levelScore;
        levelNumber = _levelNumber;
        clear = _clear;
        tries = _tries;
        sessionID = _sessionID;
    }
    public void setInfo(string _levelTime,int _levelScore,int _levelNumber,bool _clear,int _tries,int _sessionID)
    {
        levelTime = _levelTime;
        levelScore = _levelScore;
        levelNumber= _levelNumber;
        clear = _clear;
        tries = _tries;
        sessionID= _sessionID;
    }
}

public class Quest : MonoBehaviour
{
    private int id;
    private string quest_name;
    private int mistakes;
    private int quest_score;
    private string quest_time;
    private int levelID;

    public Quest(int _id, string _quest_name, int _mistakes, int _quest_score, string _quest_time, int _levelID)
    {
        id = _id;
        quest_name = _quest_name;
        mistakes = _mistakes;
        quest_score = _quest_score;
        quest_time = _quest_time;
        levelID = _levelID;
    }
    public void setInfo(int _id,string _quest_name,int _mistakes,int _quest_score,string _quest_time,int _levelID)
    {
        id = _id;
        quest_name = _quest_name;
        mistakes = _mistakes;
        quest_score = _quest_score;
        quest_time = _quest_time;
        levelID = _levelID;
    }
}
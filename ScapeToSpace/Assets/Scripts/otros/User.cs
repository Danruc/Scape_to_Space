using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private int id;
    private string username;
    private string password;
    private string creationDate;
    private int progressID;
    private string email;

    public User(int _id, string _username, string _password, string _creationDate, int _progressID, string _email)
    {
        id = _id;
        username = _username;
        password = _password;
        creationDate = _creationDate;
        progressID = _progressID;
        email = _email;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRegisterForm : MonoBehaviour
{
    public GameObject RegisterForm;
    public GameObject LoginForm;


    void Start()
    {
        
    }
    public void OpenCloseRegister()
    {
        RegisterForm.active = !RegisterForm.active;
        LoginForm.active = !LoginForm.active;
        
    }

   

    // Update is called once per frame
    void Update()
    {
    }
}

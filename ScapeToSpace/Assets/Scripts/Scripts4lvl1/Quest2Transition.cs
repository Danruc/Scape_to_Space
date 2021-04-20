using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest2Transition : MonoBehaviour
{
    public string sceneToLoad;
    public static bool Quest = true;
    public GameObject transistor;
<<<<<<< HEAD
    public GameObject image;
=======
>>>>>>> main

    void Start()
    {
        if (!Quest)
        {
            transistor.active = !transistor.active;
<<<<<<< HEAD
            image.active = !image.active;
=======
>>>>>>> main
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
<<<<<<< HEAD
            BotonChecar.quest = false;
=======
>>>>>>> main
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}



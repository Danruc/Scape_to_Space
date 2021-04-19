using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest1Transition : MonoBehaviour
{
    public string sceneToLoad;
    public static bool Quest = true;
    public GameObject transistor;
    public GameObject image;

    void Start()
    {
        if (!Quest)
        {
            image.active = !image.active;
            transistor.active = !transistor.active;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            BotonChecar.quest = true;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

    

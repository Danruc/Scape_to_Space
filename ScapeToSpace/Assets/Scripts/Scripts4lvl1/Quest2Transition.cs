using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest2Transition : MonoBehaviour
{
    public string sceneToLoad;
    public static bool Quest = true;
    public GameObject transistor;

    void Start()
    {
        if (!Quest)
        {
            transistor.active = !transistor.active;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}



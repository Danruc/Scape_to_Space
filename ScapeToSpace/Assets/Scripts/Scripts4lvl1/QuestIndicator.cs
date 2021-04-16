using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestIndicator : MonoBehaviour
{
    public static int quests = 0;
    public Text quest;
    public GameObject finalTransition;
    // Start is called before the first frame update
    void Start()
    {
        quest = GetComponent<Text>();
        finalTransition = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        quest.text = "Pruebas: " + quests + "/2";
        if(quests == 2)
        {
            finalTransition.SetActive(true);
        }

    }
}

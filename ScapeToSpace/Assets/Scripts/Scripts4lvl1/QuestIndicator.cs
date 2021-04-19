using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestIndicator : MonoBehaviour
{
    public static int quests = 0;
    public Text qs;
    public GameObject finalTransition;
    public GameObject imagen;
    // Start is called before the first frame update
    void Start()
    {
        qs = GetComponent<Text>();
        
        qs.text = "Pruebas: " + quests + "/2";
        if (quests == 2)
        {
            finalTransition.active = !finalTransition.active;
            imagen.active = !imagen.active;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}

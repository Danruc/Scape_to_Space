using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndQuest : MonoBehaviour
{
    public void completed(string sceneName)
    {
<<<<<<< HEAD
        FindObjectOfType<AudioManager>().Play("Click");
        QuestIndicator.quests += 1;
        Score.scoreValue += BotonChecar.score;

        if (BotonChecar.quest)
        {
            Quest1Transition.Quest = false;
        }
        else
        {
            Quest2Transition.Quest = false;
        }
        
        
        SceneManager.LoadScene(sceneName);

        BotonChecar.x = 0;
        BotonChecar.score = 1000;
=======
        QuestIndicator.quests += 1;
        Quest1Transition.Quest = false;
        //Score.scoreValue += Quest.acumulative;
        SceneManager.LoadScene(sceneName);
>>>>>>> main
    }

    public void notcompleted(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}

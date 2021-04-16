using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndQuest : MonoBehaviour
{
    public void completed(string sceneName)
    {
        QuestIndicator.quests += 1;
        Quest1Transition.Quest = false;
        //Score.scoreValue += Quest.acumulative;
        SceneManager.LoadScene(sceneName);
    }

    public void notcompleted(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}

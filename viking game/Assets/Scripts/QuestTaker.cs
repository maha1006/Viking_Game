using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTaker : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public QuestGoal qg;

    public GameObject questWindow;
    public GameObject questWindowReached;
    public Text titleText;
    public Text descriptionText;

    public QuestGiver aq;

    void OnTriggerEnter(Collider other)
    {
        if (aq.quest.isActive)
        {
            Debug.Log(" active");
            if (quest.isActive)
            { 
                OpenQuestWindowReached();
                Debug.Log(" reached");
            }
            else
            {
                OpenQuestWindow();
                Debug.Log(" not reached");
            }
        }

        else
        { 
            OpenQuestWindowReached();
        Debug.Log(" _reached");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (aq.quest.isActive)
        {
            Debug.Log(" active");
            if (quest.isActive)
            {
                CloseQuestWindowReached();
                gameObject.SetActive(false);
                Debug.Log(" reached");
            }
            else
            {
                CloseQuestWindow();
                Debug.Log(" not reached");
            }
        }

        else
        {
            CloseQuestWindowReached();
            gameObject.SetActive(false);
            Debug.Log(" _reached");
        }
    }

    public void ActivateQuestTaker()
    {
        gameObject.SetActive(true);
    }


    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
    }
    public void CloseQuestWindow()
    {
        questWindow.SetActive(false);
    }

    public void OpenQuestWindowReached()
    {
        questWindowReached.SetActive(true);
     
    }
    public void CloseQuestWindowReached()
    {
        questWindowReached.SetActive(false);
    }
}

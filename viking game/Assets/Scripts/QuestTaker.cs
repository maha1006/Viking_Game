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
        titleText.text = quest.title;
        descriptionText.text = quest.description;
    }
    public void CloseQuestWindow()
    {
        questWindow.SetActive(false);
        titleText.text = quest.title;
        descriptionText.text = quest.description;
    }

    public void OpenQuestWindowReached()
    {
        questWindowReached.SetActive(true);
        titleText.text = quest.title;
        descriptionText.text = quest.description;
    }
    public void CloseQuestWindowReached()
    {
        questWindowReached.SetActive(false);
        titleText.text = quest.title;
        descriptionText.text = quest.description;
    }
}

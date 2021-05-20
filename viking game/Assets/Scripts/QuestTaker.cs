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

    void OnTriggerEnter(Collider other)
    {
        if (quest.goal.IsReached())
        {
            OpenQuestWindowReached();
            Debug.Log(" reach");
        }

        else
        { 
            OpenQuestWindow();
        Debug.Log(" not reached");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (quest.goal.IsReached())
            CloseQuestWindowReached();

        else
            CloseQuestWindow();
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

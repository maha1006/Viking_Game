using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiver2 : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;


    void OnTriggerEnter(Collider other)
    {
        OpenQuestWindow();
    }

    void OnTriggerExit(Collider other)
    {
        CloseQuestWindow();
    }


    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
    }
    public void CloseQuestWindow()
    {
        questWindow.SetActive(false);
       
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        this.gameObject.SetActive(false);
        quest.isActive = true;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        player.quest = quest;
    }
}



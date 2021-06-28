using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiver2 : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public BoatController boatController;

    public GameObject questWindow;

    public GameObject Trigger;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            OpenQuestWindow();
        boatController.StopPlayer();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            CloseQuestWindow();
    }

    public void StartPlayer()
    {
        boatController.StartPlayer();
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
        Trigger.SetActive(false);
        quest.isActive = true;
        Trigger.GetComponent<CapsuleCollider>().enabled = false;
        player.quest = quest;
    }
}



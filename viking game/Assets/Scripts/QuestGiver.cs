using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;

    public questcompass qc;
    public questmarker qm;
    public PauseGameOnTrigger pause;


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
        quest.isActive = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
        qc.AddQuestMarker(qm);
        pause.Resume();
    }
    public void DeleteMarker()
    {
        qc.DeleteQuestMarker(qm);
        Debug.Log("deleted muhahhar");
    }
}



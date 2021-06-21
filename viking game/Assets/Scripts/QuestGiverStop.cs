using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiverStop : MonoBehaviour
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
        pause.Resume();

    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
       
        
    }

    public void AddMarker()
    {
        qc.AddQuestMarker(qm);
    }
    public void DeleteMarker()
    {
        qc.DeleteQuestMarker(qm);
        Debug.Log("deleted muhahhar");
    }
}



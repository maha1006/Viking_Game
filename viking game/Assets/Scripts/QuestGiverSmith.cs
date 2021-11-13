using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiverSmith : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;
    public GameObject unavailableWindow;
    public GameObject Smithers;
    public GameObject WerftDude;

    public questcompass qc;
    public questmarker QuestMarkerSmith;
    public questmarker QuestMarkerWerft;

    public QuestGiverWerft questGiverWerft;


    public bool Upgrade1;
    public bool Upgrade2;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (questGiverWerft.quest.isActive)
            {

                unavailableWindow.SetActive(true);
            }

            else
            {
                OpenQuestWindow();
            }
            
            
        }
            
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            CloseQuestWindow();
    }


    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
    }
    public void CloseQuestWindow()
    {
        questWindow.SetActive(false);
        unavailableWindow.SetActive(false);
        //questWindowRebuild.SetActive(false);

    }

    public void SpawnDockMen()
    {
        WerftDude.SetActive(true);
        Smithers.SetActive(true);
    }

    

    public void disavleTrigger()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

   

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
        qc.AddQuestMarker(QuestMarkerSmith);
        qc.AddQuestMarker(QuestMarkerWerft);
        player.GoItem();
    }

    public void AcceptRebuildQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
        player.GoItem();
    }

    public void AddQuestMarker()
    {
        qc.AddQuestMarker(QuestMarkerSmith);
        qc.AddQuestMarker(QuestMarkerWerft);
    }

    public void DeleteMarkerSmith()
    {
        qc.DeleteQuestMarker(QuestMarkerSmith);
        Debug.Log("deleted muhahhar");
    }
    
    public void DeleteMarkerWerft()
    {
        qc.DeleteQuestMarker(QuestMarkerWerft);
        Debug.Log("deleted muhahhar");
    }
}



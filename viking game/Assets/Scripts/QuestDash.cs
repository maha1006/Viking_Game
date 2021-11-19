using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestDash : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;
    public GameObject questWindowUnavailable;
    public GameObject DashSailSkin;
    public GameObject DefaultSail;
    public GameObject UpgradedSail;
    public QuestGiverRebuildSkapning questGiverRebuildSkapning;


    public questcompass qc;
    public questmarker qm;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (questGiverRebuildSkapning.Upgrade2)
            {
                OpenQuestWindow();
            }
            else
            {
                questWindowUnavailable.SetActive(true);
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
        questWindowUnavailable.SetActive(false);
       
    }

    public void disavleTrigger()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    public void UpgradeDashSkin()
    {
        DashSailSkin.SetActive(true);
        DefaultSail.SetActive(false);
        UpgradedSail.SetActive(false);

    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
        qc.AddQuestMarker(qm);
        player.GoItem();
    }
    
    public void AcceptSmithQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
        player.GoItem();
    }

    public void DeleteMarker()
    {
        qc.DeleteQuestMarker(qm);
        Debug.Log("deleted muhahhar");
    }
}



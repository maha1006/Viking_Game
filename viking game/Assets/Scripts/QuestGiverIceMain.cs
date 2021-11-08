using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiverIceMain : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;

    public questcompass qc;

    public questmarker qm_kraken;
    public questmarker qm_wal;
    public questmarker qm_leviathan;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            OpenQuestWindow();
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
       
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
        qc.AddQuestMarker(qm_kraken);
        qc.AddQuestMarker(qm_wal);
        qc.AddQuestMarker(qm_leviathan);
        player.GoItem();
    }
    public void DeleteMarkerKraken()
    {
        qc.DeleteQuestMarker(qm_kraken);
        
        Debug.Log("deleted muhahhar");
    }

    public void DeleteMarkerWal()
    {
        qc.DeleteQuestMarker(qm_wal);

        Debug.Log("deleted muhahhar");
    }
    public void DeleteMarkerLeviathan()
    {
        qc.DeleteQuestMarker(qm_leviathan);

        Debug.Log("deleted muhahhar");
    }
    
        
}



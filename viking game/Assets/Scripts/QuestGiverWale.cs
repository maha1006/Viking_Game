using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiverWale : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;

    public ActivateFlame activateFlame;

    //public questcompass qc;
    //public questmarker qm;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (activateFlame.WaleflameActive)
            {
                if (activateFlame.KrakenflameActive)
                {
                    if (activateFlame.LeviathanflameActive)
                    {
                        activateFlame.OpenWindowNext2Flames();
                    }
                    else
                    {
                        OpenQuestWindow();
                    }
                }
                else
                {
                    OpenQuestWindow();
                    Debug.Log(" not reached");
                }
            }
            else
            {
                OpenQuestWindow();
                Debug.Log(" not reached");
            }
        }
        else
        {
            OpenQuestWindow();
            Debug.Log(" _reached");
        }

        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CloseQuestWindow();
            activateFlame.WindowNext2Flames.SetActive(false);
        }
    }


    public void OpenQuestWindow()
    {
        activateFlame.FlameWindowNext();
        //questWindow.SetActive(true);
    }
    public void CloseQuestWindow()
    {
        activateFlame.CloseNextWindows();


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
        //qc.AddQuestMarker(qm);
        player.GoItem();
    }
    public void DeleteMarker()
    {
        //qc.DeleteQuestMarker(qm);
        //Debug.Log("deleted muhahhar");
    }
}



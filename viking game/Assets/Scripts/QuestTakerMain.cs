using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTakerMain : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public QuestGoal qg;

    public GameObject questWindow;
    public GameObject questWindowReached;
    public GameObject questWindow2;
    public ActivateFlame activateFlame;

    public Text titleText;
    public Text descriptionText;

    public QuestGiverIceMain questGiverMain;

    public questcompass qc;
    public questmarker qm;

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
                        OpenQuestWindowReached();
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
        if (questGiverMain.quest.isActive)
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
            CloseQuestWindow();
            Debug.Log(" _reached");
        }
    }

    public void DeleteCollider()
    {
        this.gameObject.SetActive(false);
    }
    public void ActivateQuestTaker()
    {
        gameObject.SetActive(true);
    }


    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
    }
    public void CloseQuestWindow()
    {
        questWindow.SetActive(false);
        questWindow2.SetActive(false);
    }

    public void OpenQuestWindowReached()
    {
        questWindowReached.SetActive(true);
     
    }
    public void CloseQuestWindowReached()
    {
        questWindowReached.SetActive(false);
        
        
    }

    public void DeleteMarker()
    {
        qc.DeleteQuestMarker(qm);
        Debug.Log("deleted muhahhar");
    }
}

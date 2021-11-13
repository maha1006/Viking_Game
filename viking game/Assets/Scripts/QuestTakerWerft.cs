using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTakerWerft : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public QuestGoal qg;

    public GameObject questWindow;
    public GameObject questWindowReached;
    public GameObject RammbockV2;
    public GameObject RammbockV1;

    public Text titleText;
    public Text descriptionText;

    public QuestGiverSmith questGiverSmith;
    public QuestGiverWerft questGiverWerft;

   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            if (questGiverWerft.quest.isActive)
        {
            Debug.Log(" active");
            if (quest.isActive)
            { 
                OpenQuestWindowReached();
                Debug.Log(" reached");
            }
            else
            {
                OpenQuestWindow();
                Debug.Log(" not reached");
            }
        }

        else
        { 
            OpenQuestWindowReached();
        Debug.Log(" _reached");
        }
        }

    }



    void OnTriggerExit(Collider other)
    {
        if (questGiverWerft.quest.isActive)
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
            CloseQuestWindowReached();
            Debug.Log(" _reached");
        }
    }

    public void UpgradeBrecher()
    {
        RammbockV2.SetActive(true);
        RammbockV1.SetActive(false);
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
    }

    public void OpenQuestWindowReached()
    {
        questWindowReached.SetActive(true);
     
    }
    public void CloseQuestWindowReached()
    {
        questWindowReached.SetActive(false);
        
    }

    
}

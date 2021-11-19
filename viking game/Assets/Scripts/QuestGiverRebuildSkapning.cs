using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiverRebuildSkapning : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;
    public GameObject questWindowRebuild;
    public GameObject Button;
    public GameObject Smithers;
    public GameObject WerftDude;
    public GameObject UpgradeV0;
    public GameObject UpgradeV1;
    public GameObject UpgradeV2;
    public GameObject WerftUpgrade;
    public GameObject SmithUpgrade;
    public GameObject Citizen1;
    public GameObject Citizen2;

    public questcompass qc;
    public questmarker QuestMarkerSmith;
    public questmarker QuestMarkerWerft;
    

    public bool Upgrade1;
    public bool Upgrade2;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(Upgrade1)
            {
                if(Upgrade2)
                {
                    questWindowRebuild.SetActive(true);
                }
                else if (Upgrade1)
                {
                    OpenQuestWindow();
                }
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
        questWindowRebuild.SetActive(false);
       
    }


    public void UpgradeCitizens()
    {
        
            if (Upgrade1)
            {
                if (Upgrade2)
                {
                    Citizen1.SetActive(true);
                }
                else if (Upgrade1)
                {
                    Citizen2.SetActive(true);
                }
            }

            else
            {
                  Citizen2.SetActive(true);
            }
        
    }

    public void SpawnDockMen()
    {
        WerftDude.SetActive(true);
        Smithers.SetActive(true);
    }

    public void DeleteButton()
    {
        Destroy(Button);
    }

    public void disavleTrigger()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

   public void UpgradeWerft()
    {
        Upgrade1 = true;
        WerftUpgrade.SetActive(true);
    }
    
    public void UpgradeSmithy()
    {
        Upgrade2 = true;
        SmithUpgrade.SetActive(true);

    }

    public void UpgradeVersion1()
    {
        UpgradeV0.SetActive(false);
        UpgradeV1.SetActive(true);
        print("Verion1");
    }
    
    public void UpgradeVersion2()
    {
        UpgradeV1.SetActive(false);
        UpgradeV2.SetActive(true);
        print("Verion2");
    }

    public void SkapningUpgrade()
    {
        if(UpgradeV1.activeInHierarchy == true)
        {
            UpgradeVersion2();
        }
        else
        {
            UpgradeVersion1();
        }
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



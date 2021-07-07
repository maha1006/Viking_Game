using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeBoatBrecher : MonoBehaviour
{

    public GameObject Brecher;
    public GameObject SailUpgrade;
    public GameObject SailDefault;
    public BoatController boatController;
    public bool UpgradeActive = false;
    public bool UpgradeSegel = false;
    

    public QuestTaker1 questTaker1;
    public QuestTaker questTaker;

    public void Upgrade()
    {
        UpgradeActive = true;
        Brecher.gameObject.SetActive(true);
        questTaker1.questWindowReached.SetActive(false);
    }

    public void UpgradeSegelFast()
    {
        UpgradeSegel = true;
        SailUpgrade.gameObject.SetActive(true);
        SailDefault.gameObject.SetActive(false);
        questTaker.questWindowReached.SetActive(false);
        boatController.fwdSpeed = 65;
        boatController.revSpeed = 40;
        boatController.turnSpeed = 80;
    }

}

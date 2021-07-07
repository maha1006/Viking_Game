using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeBoatBrecher : MonoBehaviour
{

    public GameObject Brecher;
    public bool UpgradeActive = false;
    

    public QuestTaker1 questTaker;
    
    public void Upgrade()
    {
        UpgradeActive = true;
        Brecher.gameObject.SetActive(true);
        questTaker.questWindowReached.SetActive(false);
    }

}

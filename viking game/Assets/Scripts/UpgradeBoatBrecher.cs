using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeBoatBrecher : MonoBehaviour
{

    public GameObject Brecher;
    

    public QuestTaker1 questTaker;
    void Start()
    {

        Brecher.gameObject.SetActive(false);
    }
    public void Upgrade()
    {
        Brecher.gameObject.SetActive(true);
        questTaker.questWindowReached.SetActive(false);
    }

}

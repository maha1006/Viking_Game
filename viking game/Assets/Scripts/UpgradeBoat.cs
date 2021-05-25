using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeBoat : MonoBehaviour
{

    private GameObject Car;
    private GameObject Car2;

    public QuestTaker questTaker;
    void Start()
    {
        Car = GameObject.Find("Rowboat_Blue");
        Car.gameObject.SetActive(true);

        Car2 = GameObject.Find("Upgrade_Blue_Car");
        Car2.gameObject.SetActive(false);
    }
    public void Upgrade()
    {
            Car.gameObject.SetActive(false);
            Car2.gameObject.SetActive(true);
            questTaker.questWindowReached.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = false;

    }

}

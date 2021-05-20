using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeBoat : MonoBehaviour
{

    private GameObject Car;
    private GameObject Car2;
    void Start()
    {
        Car = GameObject.Find("Rowboat_Blue");
        Car.gameObject.SetActive(true);

        Car2 = GameObject.Find("Upgrade_Blue_Car");
        Car2.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Car.gameObject.SetActive(false);
            Car2.gameObject.SetActive(true);
        }
    }

}

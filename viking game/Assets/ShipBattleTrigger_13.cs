using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_13 : MonoBehaviour
{
    public BattleSystem13 openBattleSystem;
    public BoatController boatController;
    public GameObject impact;
    public GameObject LoseWindow;
    




    public void start()
    {
        impact.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openBattleSystem.gameObject.SetActive(true);
            boatController.StopPlayer();
            impact.SetActive(true);
        }
    }

    public void tryagain()
    {
        LoseWindow.SetActive(false);
       // LoseWindow2.SetActive(false);
        openBattleSystem.gameObject.SetActive(true);
        boatController.StopPlayer();
        impact.SetActive(true);
    }

    public void getaway()
    {
        LoseWindow.SetActive(false);
       // LoseWindow2.SetActive(false);
        openBattleSystem.getaway();
    }

    public void toggleOffImpact()
    {
        impact.SetActive(false);
    }

    public void Update()
    {
        if (openBattleSystem.gameObject.activeInHierarchy == true)
        {
            boatController.StopPlayer();

        }
    }
}

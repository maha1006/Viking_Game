using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_5 : MonoBehaviour
{
    public BattleSystem5 openBattleSystem;
    public PathFollower pathFollow;
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
            pathFollow.StopShip();
            boatController.StopPlayer();
            impact.SetActive(true);
        }
    }

    public void tryagain()
    {
        LoseWindow.SetActive(false);
        openBattleSystem.gameObject.SetActive(true);
        pathFollow.StopShip();
        boatController.StopPlayer();
        impact.SetActive(true);
    }

    public void getaway()
    {
        LoseWindow.SetActive(false);
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

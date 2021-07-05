using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_5 : MonoBehaviour
{
    public BattleSystem5 openBattleSystem;
    public BoatController boatController;
    public PathFollower pathFollow;


    public void Destroy()
    {
        Destroy(this.gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openBattleSystem.gameObject.SetActive(true);
            pathFollow.StopShip();
            boatController.StopPlayer();
        }
    }
}

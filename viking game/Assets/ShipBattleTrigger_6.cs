using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_6 : MonoBehaviour
{
    public BattleSystem6 openBattleSystem;
    public BoatController boatController;
    public PathFollower pathFollow;


    public void Destroy()
    {
        Destroy(this.gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        openBattleSystem.gameObject.SetActive(true);
        pathFollow.StopShip();
        boatController.StopPlayer();
    }
}

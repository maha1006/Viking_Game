using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_1 : MonoBehaviour
{
    public BattleSystem1 openBattleSystem;
    public BoatController boatController;


    public void Destroy()
    {
        Destroy(this.gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        openBattleSystem.gameObject.SetActive(true);
        boatController.StopPlayer();
    }
}

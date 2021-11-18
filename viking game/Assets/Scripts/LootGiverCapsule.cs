using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootGiverCapsule : MonoBehaviour
{
    public CollectItem collectItem;

    public Quest quest;

    public Player player;

    public GameObject lootWindow;

    public int woodCount;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            OpenLootWindow();
    }

    void OnTriggerExit(Collider other)
    {
        CloseLootWindow();
    }


    public void OpenLootWindow()
    {
        lootWindow.SetActive(true);
    }
    public void CloseLootWindow()
    {
        lootWindow.SetActive(false);

    }

    public void CollectIslandLoot()
    {
        //Destroy(gameObject);
        lootWindow.SetActive(false);
        //gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        ScoringSystem.theScore += woodCount;
        player.GoItem();
    }
}

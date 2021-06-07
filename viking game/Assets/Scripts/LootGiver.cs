using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootGiver : MonoBehaviour
{
    public CollectItem collectItem;

    public CollectItemIron collectIron;

    public Quest quest;

    public Player player;

    public GameObject lootWindow;

    public int woodCount;
    public int ironCount;


    void OnTriggerEnter(Collider other)
    {
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
        lootWindow.SetActive(false);
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.quest = quest;
        ScoringSystem.theScore += woodCount;
        ScoringSystemIron.theScore += ironCount;
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemIron : MonoBehaviour
{
    public AudioSource collectSound;
    public Quest quest;
    public Player goItem;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystemIron.theScore += 1;
        goItem.GoItem();
        Destroy(gameObject);
    }


}


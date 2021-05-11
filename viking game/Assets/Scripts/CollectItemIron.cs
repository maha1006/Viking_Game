using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemIron : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystemIron.theScore += 1;
        Destroy(gameObject);
    }


}


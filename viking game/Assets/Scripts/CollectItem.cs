using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public AudioSource collectSound;
    public Quest quest;
    public Player goItem;

    public Animation anim;

    private void Start()
    {
        anim.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.Play();
            collectSound.Play();
            ScoringSystem.theScore += 1;
            goItem.GoItem();
            Destroy(gameObject);
            
        }
    }

    public void CollectItemScore()
    {
        ScoringSystem.theScore += 1;
    }
}


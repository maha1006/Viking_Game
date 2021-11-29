using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllScript : MonoBehaviour
{
    public AudioSource appear;
    public AudioSource death;
    public AudioSource battle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Appear();
            Battle();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BattleLose();
        }
    }

    public void Appear()
    {
        appear.Play();
    }
    
    public void Death()
    {
        death.Play();
    }
    
    public void Battle()
    {
        battle.Play();
    }
    
    public void BattleLose()
    {
        battle.Stop();
    }

}

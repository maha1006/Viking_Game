using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwap2 : MonoBehaviour
{
    public AudioClip newTrack;
    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
        {
                SwapTrack();
        }
    } 
    private void OnTriggerExit(Collider other)
    {
       if(other.CompareTag("Player"))
        {
            ReturnToDefault();
           
        }
    }
    public void SwapTrack()
    {
        {
            AudioManager.instance.SwapTrack(newTrack);
        }
    }

    public void ReturnToDefault()
    {
        {
            AudioManager.instance.ReturnToDefault();
        }
    }
    
}

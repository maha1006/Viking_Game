using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwap : MonoBehaviour
{
    public AudioClip newTrack;
    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
        {
            SwapTrack();
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

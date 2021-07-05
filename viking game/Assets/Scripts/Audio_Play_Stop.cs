using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Play_Stop : MonoBehaviour
{

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    public void StopAudio()
    {
        audioSource.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    public GameObject audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.SetActive(false);
    }

    public void PlayWav()
    {
        audioSource.SetActive(true);
    }
}

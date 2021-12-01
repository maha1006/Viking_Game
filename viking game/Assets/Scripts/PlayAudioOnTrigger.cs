using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{

    public AudioSource source;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            source.Play();
        }
    }

    public void PlayAudioWait()
    {
        StartCoroutine(PlayWait());
    }

    IEnumerator PlayWait()
    {
        yield return new WaitForSeconds(2);
        source.Play();
    }
}

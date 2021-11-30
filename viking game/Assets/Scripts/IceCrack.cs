using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCrack : MonoBehaviour
{
    public AudioSource iceSound;

    public AudioClip[] audioClipArray;


    void Awake()
    {
        iceSound = GetComponent<AudioSource>();
    }

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ice")
        {
            iceSound.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
            iceSound.PlayOneShot(iceSound.clip);
        }
    }
}

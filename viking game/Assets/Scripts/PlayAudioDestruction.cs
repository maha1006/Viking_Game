using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioDestruction : MonoBehaviour
{
    public GameObject DestructionSound;
    void Start()
    {
        DestructionSound.SetActive(false);
    }
    public void DestroyBoat()
    {
        DestructionSound.SetActive(true);
    }
}

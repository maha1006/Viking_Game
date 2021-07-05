using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audi_Swap_Default_Sound : MonoBehaviour
{
    public AudioSwap audiSwap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audiSwap.ReturnToDefault();
        }
    }

}

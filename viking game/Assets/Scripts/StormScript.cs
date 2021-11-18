using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class StormScript : MonoBehaviour
{
    public GameObject Tornado;
    public GameObject StormCollider;
    public PathFollower pathFollower;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           pathFollower.StartTornado();
            Tornado.SetActive(true);
        }
    }

    public void DeactivateTrigger()
    {
        StormCollider.SetActive(false);
    }
}

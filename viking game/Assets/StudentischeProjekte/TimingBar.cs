using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingBar : MonoBehaviour
{
    public Transform LookAt;
    public Transform Trigger;

    void OnTriggerEnter(Collider other)
    {
        LookAt.position = Trigger.position;
    }

    void Update()
    {
    }
}

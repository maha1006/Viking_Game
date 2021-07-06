using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMass : MonoBehaviour
{
    public Rigidbody controllerSphere;
    public float mass;

    void Start()
    {
        controllerSphere = GetComponent<Rigidbody>();
        controllerSphere.mass = mass;
    }

    public void MassChange()
    {
        controllerSphere.mass = 13;
    }
}

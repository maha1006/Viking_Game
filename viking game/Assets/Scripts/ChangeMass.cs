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
    
    public void MassChange2()
    {
        controllerSphere.mass = 55;
    }

    void OnCollisionEnter(Collision c)
    {
        float force = 400000;

        if (c.gameObject.tag == "enemy")
        {
            if (controllerSphere.mass > 56)
            {
                Vector3 dir = c.contacts[0].point - transform.position;
                dir = -dir.normalized;
                GetComponent<Rigidbody>().AddForce(dir * force * 2);
            }
            else
            {
                Vector3 dir = c.contacts[0].point - transform.position;
                dir = -dir.normalized;
                GetComponent<Rigidbody>().AddForce(dir * force);
            }
        }
    }
}

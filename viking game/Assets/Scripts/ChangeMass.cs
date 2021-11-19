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
        // force is how forcefully we will push the player away from the enemy.
        float force = 2500;

        // If the object we hit is the enemy
        if (c.gameObject.tag == "enemy")
        {
            // Calculate Angle Between the collision point and the player
            Vector3 dir = c.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * force);
        }
    }
}

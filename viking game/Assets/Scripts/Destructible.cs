using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    public void DestroyBoat()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        //Destroy(gameObject);
        //Invoke("DestroyedBoatOff", 5);

    }
   
   
}

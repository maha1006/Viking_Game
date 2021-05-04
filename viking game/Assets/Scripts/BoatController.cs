using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    private float moveInput;

    public float fwdSpeed;

    public Rigidbody sphereRB;


    void Start()
    {
        
    }

    void Update()
    {

        moveInput = Input.GetAxisRaw("Vertical");
        moveInput *= fwdSpeed;


        transform.position = sphereRB.transform.position;
    }

    private void FixedUpdate()
    {
        sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
    }
}

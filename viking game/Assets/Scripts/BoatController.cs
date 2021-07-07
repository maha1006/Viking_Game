using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    private float moveInput;
    private float turnInput;

    public float fwdSpeed;
    public float revSpeed;
    public float turnSpeed;

    public Rigidbody sphereRB;
    public UpgradeBoatBrecher upgradeBoatBrecher;


    void Start()
    {
        sphereRB.transform.parent = null;

    }

    public void StopPlayer()
    {
        fwdSpeed = 0;
        revSpeed = 0;
        turnSpeed = 0;
    }
    public void StartPlayer()
    {
        if (upgradeBoatBrecher.UpgradeSegel == true)
        {
            fwdSpeed = 65;
            revSpeed = 40;
            turnSpeed = 80;
            Debug.Log("reset upgrade speed");
        }
        else
        {
            fwdSpeed = 50;
            revSpeed = 30;
            turnSpeed = 60;
            Debug.Log("reset default speed");
        }
        

       
    }
    void Update()
    {

        moveInput = Input.GetAxisRaw("Vertical");
        turnInput = Input.GetAxisRaw("Horizontal");

        moveInput *= moveInput > 0 ? fwdSpeed : revSpeed;


        transform.position = sphereRB.transform.position;

        float newRotation = turnInput * turnSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");
        transform.Rotate(0, newRotation, 0, Space.World);
    }

    private void FixedUpdate()
    {
        sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
    }
}

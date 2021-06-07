using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandLUL : MonoBehaviour
{
    public GameObject objB;
    bool isMove = false;
    float speed = 40;
    Vector3 targetPosition;
    Vector3 currentPosition;
    Vector3 directionOfTravel;

    void Start()
    {
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        GreenMail();
    }
    private void GreenMail()
    {
        targetPosition = objB.transform.position; // Get position of object B
        currentPosition = this.transform.position; // Get position of object A
        directionOfTravel = targetPosition - currentPosition;
        if (Vector3.Distance(currentPosition, targetPosition) > .1f)
        {
            this.transform.Translate(
                (directionOfTravel.x * speed * Time.deltaTime),
                (directionOfTravel.y * speed * Time.deltaTime),
                (directionOfTravel.z * speed * Time.deltaTime),
                Space.World);
        }
        else
        {
            isMove = false;
        }
    }
}

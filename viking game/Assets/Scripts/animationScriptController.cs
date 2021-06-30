using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScriptController : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("IsPaddling");
        bool isWalkingbackwards = animator.GetBool("IsPaddlingbackwards");

        bool forwardPress = Input.GetKey("w");
        bool backwardPress = Input.GetKey("s");

        if (!isWalking && forwardPress)
        {
            animator.SetBool("IsPaddling", true);
        }
        if (isWalking && !forwardPress)
        {
            animator.SetBool("IsPaddling", false);
        }


        if (!isWalkingbackwards && backwardPress)
        {
            animator.SetBool("IsPaddlingbackwards", true);
        }
        if (isWalkingbackwards && !backwardPress)
        {
            animator.SetBool("IsPaddlingbackwards", false);
        }
    }
}

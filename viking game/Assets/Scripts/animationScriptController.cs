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
        bool isWalkingleft = animator.GetBool("isLeft");
        bool isWalkingright = animator.GetBool("isRight");

        bool forwardPress = Input.GetKey("w");
        bool backwardPress = Input.GetKey("s");
        bool leftPress = Input.GetKey("a");
        bool rightPress = Input.GetKey("d");

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

        if (!isWalkingleft && leftPress)
        {
            animator.SetBool("isLeft", true);
        }
        if (isWalkingleft && !leftPress)
        {
            animator.SetBool("isLeft", false);
        }

        if (!isWalkingright && rightPress)
        {
            animator.SetBool("isRight", true);
        }
        if (isWalkingright && !rightPress)
        {
            animator.SetBool("isRight", false);
        }
    }
}

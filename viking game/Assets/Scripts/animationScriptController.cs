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
        bool forwardPress = Input.GetKey("w");
        if (!isWalking && forwardPress)
        {
            animator.SetBool("IsPaddling", true);
        }
        if (isWalking && !forwardPress)
        {
            animator.SetBool("IsPaddling", false);
        }
    }
}

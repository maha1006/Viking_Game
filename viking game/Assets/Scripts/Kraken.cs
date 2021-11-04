using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraken : MonoBehaviour
{
    public Animator enemyAnimator;
    public Rigidbody rigidbody;

    void Start()
    {
        rigidbody.useGravity = false;
    }

    
    public void enablegravity ()
    {
        rigidbody.useGravity = true;
    }

    public void Death()
    {
        enemyAnimator.SetTrigger("Death");
    }
}

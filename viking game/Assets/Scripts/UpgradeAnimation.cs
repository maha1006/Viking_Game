using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeAnimation : MonoBehaviour
{
    public ParticleSystem particleSplash;
    public ParticleSystem particleCircle;
    void Start()
    {
        particleSplash.Stop();
        particleCircle.Stop();
    }

   
    public void PlayAnimation()
    {
        particleSplash.Play();
        particleCircle.Play();
    }
}

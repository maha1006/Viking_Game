using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingBar : MonoBehaviour
{
    public Transform Zeiger;
    public Transform PosA;
    public Transform PosB;
    float initialOffset;
    float currentPosition;

    void Start()
    {
        initialOffset = Random.Range(0f, 1f);
        Zeiger.localPosition = Vector3.Lerp(PosA.localPosition, PosB.localPosition, initialOffset);
    }

    void Update()
    {
        currentPosition = Mathf.PingPong(Time.time + initialOffset, 1f);
        Zeiger.localPosition = Vector3.Lerp(PosA.localPosition, PosB.localPosition, currentPosition);
    }
}

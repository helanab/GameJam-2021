using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireFlyMove : MonoBehaviour
{
    float originalY;

    public float floatStrength = 1;
    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)System.Math.Sin(Time.time) * floatStrength),
            transform.position.z);
    }
}
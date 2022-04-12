using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class CloudScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
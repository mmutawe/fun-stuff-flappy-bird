using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesTrapMovement : MonoBehaviour
{
    private const float LeftSpeed = 2.5F;
    private float deadZone = -5F;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * (LeftSpeed * Time.deltaTime);
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}

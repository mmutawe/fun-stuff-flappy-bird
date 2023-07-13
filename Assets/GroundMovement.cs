using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    private const float LeftSpeed = 2.5F;
    private float deadZone = -6.59F;
    
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

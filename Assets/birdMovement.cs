using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    
    public float upSpeed = 5;
    public float rotationSpeed = -140;
    void Start()
    {
        gameObject.name = "flappy bird";
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.rotation.eulerAngles.z;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * upSpeed ;
            // myRigidbody2D.AddForce(Vector2.up * 500);
            transform.rotation = Quaternion.Euler(new Vector3(0,0,80));
        }

        if (zRotation < 90f || zRotation > 270f)
        {
            // Debug.Log("Rotation : " + transform.localEulerAngles.z);
            // Debug.Log("Rotation : " + transform.rotation.eulerAngles.z);
            transform.Rotate(new Vector3(0,0, rotationSpeed) * Time.deltaTime, Space.Self);
        }
        // else
        // {
        //     Debug.Log("Rotation is larger than -90 degrees.");
        //     transform.rotation = Quaternion.Euler(new Vector3(0,0,-90));
        // }

    }
}

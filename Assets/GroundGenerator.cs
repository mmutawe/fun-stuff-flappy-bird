using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject ground;
    // (6.59 + 6.59)/2.5 = 5.272
    private float spawnRate = 2.5F;
    private float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnRate)
        {
            timer = 0;
            Instantiate(ground, transform.position + Vector3.down * 6.08F, transform.rotation);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGeneratorScript : MonoBehaviour
{

    public GameObject pipe;

    private float spawnRate = 2.5F;
    private float timer = 0; 
    private float range = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnRate)
        {
            timer = 0;
            range = Random.Range(-3F, 3F);
            Instantiate(pipe, transform.position + Vector3.up * range, transform.rotation);
        }
        else
        {
            timer += Time.deltaTime;
        }

    }
}

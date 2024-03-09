using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundry = 50f;
    private float lowerBoundry = -10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundry ||  transform.position.z < lowerBoundry)
        {
            Destroy(gameObject);   
        }
    }
}

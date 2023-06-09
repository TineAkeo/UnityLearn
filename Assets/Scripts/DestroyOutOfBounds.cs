using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40f;
    private float bottomBound = -40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

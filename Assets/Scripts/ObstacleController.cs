using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float obstacleSpeed = 0.5f;
    private float deadX = -5.5f;

    void Start()
    {
        
    }

    void Update()
    {
        // move left over time
        obstacleSpeed += obstacleSpeed * 0.001f;
        transform.position += (Time.deltaTime * (Vector3.left * obstacleSpeed));

        if (transform.position.x < deadX)
        {
            Destroy(this.gameObject);
        }
        
    }

    
}

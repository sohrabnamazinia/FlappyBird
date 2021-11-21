using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProducer : MonoBehaviour
{
    public GameObject obstacle;
    GameObject go;
    float timer = 0f;
    public float gapTime = 2f;
    public float obstacleCenterY;

    void Start()
    {
        
    }

    void Update()
    {
        if (timer < gapTime)
        {
            timer += Time.deltaTime;   
        }
        else
        {
            go = Instantiate(obstacle);
            Vector3 newObstaclePos = transform.position;
            newObstaclePos.y += Random.Range(-obstacleCenterY, obstacleCenterY);
            go.transform.position = newObstaclePos;
            // reset timer and remove the wasted obstacle 
            timer = 0;
        }
    }

    
}

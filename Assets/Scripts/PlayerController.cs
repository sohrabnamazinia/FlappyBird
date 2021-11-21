using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameController gameController;
    Rigidbody2D rb;
    public float Score;
    public bool isLost;
    [Range(0f, 10f)] public float playerSpeed = 3f;

    void Start()
    {
        Score = 0;
        isLost = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * playerSpeed;
        }
        
        Score += 0.1f;

        if (!isLost)
        {
            gameController.UpdateScore();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isLost = true;
        Score = 0;
        gameController.FinishGame();
    }


}

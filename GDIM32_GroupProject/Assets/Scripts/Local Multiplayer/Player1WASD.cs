using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen


public class Player1WASD : MonoBehaviour
{
    public float Speed;
    float MovementX;
    float MovementY;
    private Rigidbody2D Rb;
        void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        MovementX = 0;
        MovementY = 0;

    }

    void Update()
    {
        Rb.velocity = new Vector2(MovementX * Speed * Time.deltaTime, MovementY * Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            MovementY = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MovementY = -1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            MovementX = -1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MovementX = 1;
        }

        if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.S))
        {
            MovementY = 0;
        }

        if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D))
        {
            MovementX = 0;
        }
    }
}

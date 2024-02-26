using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen


public class PlayerControls : MonoBehaviour
{
    [Header("Controls")]
    [SerializeField] private KeyCode moveRightKey;
    [SerializeField] private KeyCode moveLeftKey;
    [SerializeField] private KeyCode moveUpKey;
    [SerializeField] private KeyCode moveDownKey;

    public float playerSpeed;
    private Rigidbody2D rb;
    private float movementX = 0f;
    private float movementY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(moveRightKey))
        {
            movementX = 1f;

        }
        else if (Input.GetKey(moveLeftKey))
        {
            movementX = -1f;

        }
        else
        {
            movementX = 0f;
        }

        if (Input.GetKey(moveUpKey))
        {
            movementY = 1f;
        }
        else if (Input.GetKey(moveDownKey))
        {
            movementY = -1f;
        }
        else
        {
            movementY = 0f;
        }
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movementX * playerSpeed, movementY * playerSpeed);
    }
}
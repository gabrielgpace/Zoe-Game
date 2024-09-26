using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    //MOVE
    [SerializeField] private float speed =5f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var moveX = 0f;
        
        if (Input.GetKey(KeyCode.D))
        {
            moveX = speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveX = -speed;
        }
        
        rb.velocity = new Vector2(moveX, rb.velocity.y);
    }
    
    

    
}

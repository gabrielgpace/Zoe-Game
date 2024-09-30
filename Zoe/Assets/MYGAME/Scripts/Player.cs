using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    //MOVE
    [SerializeField] private float speed =5f;

    //ANIMAÇÃO DE ANDAR
    public Animator anim;
    
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
            anim.SetBool("IsWalking", true);
            transform.eulerAngles = new Vector3(0,0,0);
            moveX = speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IsWalking", true);
            transform.eulerAngles = new Vector3(0,180,0);
            moveX = -speed;
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
        
        rb.velocity = new Vector2(moveX, rb.velocity.y);
    }    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public Transform feetPosition;
    public LayerMask ground;
    [SerializeField] private Rigidbody2D rb;

    private float speed = 20f;
    [SerializeField] private float jumpForce;
    [SerializeField] private float groundChecker = 0.1f;
    private bool IsGrounded;
    private float moveInput;
    



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       
            moveInput = Input.GetAxis("Horizontal");
            Vector3 velocity = new Vector3(moveInput, 0, 0) * speed;
            velocity.y = rb.velocity.y;
            Vector3 worldVelocity = transform.TransformVector(velocity);
            rb.velocity = worldVelocity;

            IsGrounded = Physics2D.OverlapCircle(feetPosition.position, groundChecker, ground);
            if (IsGrounded == true && Input.GetKey(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        
           
    }
   
}

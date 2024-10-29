using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrunkMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which Crunk moves
    public float jumpForce = 9.84f; // Force applied for jumping
    public SpriteRenderer spriteRenderer; // To flip the sprite based on direction
    public Rigidbody2D rb; // Rigidbody2D component

    public LayerMask groundLayer; // Layer for ground detection
    private bool isGrounded;
    public Transform feetPosition; // Position of Crunk's feet for ground check
    public float groundCheck = 0.2f; // Radius of ground check

    private float moveInput;

    void Update()
    {
        // Get input for horizontal movement
        moveInput = Input.GetAxisRaw("Horizontal");

        // Flip sprite based on direction
        if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveInput > 0)
        {
            spriteRenderer.flipX = false;
        }

        // Check if Crunk is on the ground
        isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheck, groundLayer);

        // Jump if on the ground and jump button is pressed
        if (isGrounded && Input.GetButton("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void FixedUpdate()
    {
        // Move Crunk horizontally
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}

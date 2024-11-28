using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : Player
{
    private Vector2 moveInput;

    private void FixedUpdate()
    {
        HandleMovement();
        HandlerJump();
    }

    private void HandlerJump()
    {
        if(PlayerInputHandler.Instance.JumpTriggered && checkGrounded())
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void HandleMovement()
    {
        moveInput = PlayerInputHandler.Instance.MoveInput;

        rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, rb.linearVelocityY);
    }
}

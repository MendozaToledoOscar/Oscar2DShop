using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public Animator animatior;

    Vector2 movement;

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        animatior.SetFloat("Horizontal", movement.x);
        animatior.SetFloat("Vertical", movement.y);
        animatior.SetFloat("Speed", movement.sqrMagnitude);
    }
}

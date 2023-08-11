using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public List<Animator> animators;

    Vector2 movement;

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        for (int i = 0; i < animators.Count; i++)
        {
            animators[i].SetFloat("Horizontal", movement.x);
            animators[i].SetFloat("Vertical", movement.y);
            animators[i].SetFloat("Speed", movement.sqrMagnitude);
        }
    }
}

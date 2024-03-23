using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.fixedDeltaTime;
        movement = new Vector2(horizontal, vertical);
        MovePlayerCharacter();
    }

    void MovePlayerCharacter()
    {
        rb.velocity = movement;
    }
}
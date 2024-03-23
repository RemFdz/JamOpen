using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float mooveSpeed;
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * mooveSpeed * Time.deltaTime;

        MovePlayerCharacter(horizontal);
    }

    void MovePlayerCharacter(float _horizontal)
    {
        Vector3 targetVelocity = new Vector2(_horizontal, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
}

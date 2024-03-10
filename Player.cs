using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coins = 0;
    public float moveSpeed = 5f;
    public float jumpHeight = 8f;
    bool isGrounded;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        MoveLeftRight(horizontalInput);

        if (Input.GetButtonDown("Jump") && isGrounded) PlayJump();
    }

    void MoveLeftRight(float x)
    {
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
    }

    void PlayJump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }

    public void OnCollisionEnter2D()
    {
        isGrounded = true;
    }
    public void OnCollisionExit2D()
    {
        isGrounded = false;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float inputDirection;
    public float speed;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator anim;
    public float jumpPower;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        CheckInput();
    }

    private void FixedUpdate()
    {
        Movement();
        UpdateAnimation();
    }

    private void CheckInput()
    {
        inputDirection = Input.GetAxis("Horizontal");
        FlipCharacter();

        
        if (Input.GetButtonDown("Jump") && GroundCheck.isGrounded)
        {
            Jump();
        }
    }

    private void Movement()
    {
        rb.velocity = new Vector2(speed * inputDirection, rb.velocity.y);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }

    private void UpdateAnimation()
    {
        if (GroundCheck.isGrounded == true)
        {
            anim.SetBool("Jump", true);
            anim.SetBool("Run", false);
        }
        else
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Run", rb.velocity.x != 0);
        }
    }

    private void FlipCharacter()
    {
        if (inputDirection > 0)
        {
            sr.flipX = false; // Saða doðru gidiyorsa, sprite'ý yansýtmýyoruz (saða bakýyor)
        }
        else if (inputDirection < 0)
        {
            sr.flipX = true; // Sola doðru gidiyorsa, sprite'ý yansýtýyoruz (sola bakýyor)
        }
    }
}

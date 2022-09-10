using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class ArthurMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private float horizDirection;
    private float vertDirection;

    private Rigidbody2D rb;
    private BoxCollider2D collider;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizDirection = Input.GetAxisRaw("Horizontal");
        vertDirection = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizDirection * moveSpeed, vertDirection * moveSpeed);

        if (horizDirection != 0 || vertDirection != 0) {
            animator.SetFloat("Velocity", 1);
            if (horizDirection != 0) {
                spriteRenderer.flipX = horizDirection < 0;
            }
        } else {
            animator.SetFloat("Velocity", 0);
        }
    }
}

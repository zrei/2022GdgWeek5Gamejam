using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class ArthurMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private float direction;

    private Rigidbody2D rb;
    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);

        if (direction > 0) {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        } else if (direction < 0) {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }
    }
}

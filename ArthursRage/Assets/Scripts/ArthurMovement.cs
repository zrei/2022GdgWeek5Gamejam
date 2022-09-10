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

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizDirection = Input.GetAxisRaw("Horizontal");
        vertDirection = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizDirection * moveSpeed, vertDirection * moveSpeed);

        /*if (horizDirection > 0) {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        } else if (horizDirection < 0) {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }*/
    }
}

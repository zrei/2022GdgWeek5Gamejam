using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{
    [SerializeField] private float speed;
    public Vector2 velocity;
    private bool isMoving = true;
    
    private SpriteRenderer spriteRenderer;

    public void setVelocity(Vector2 v) {
        velocity = v;
    }

    // Start is called before the first frame update
    void Start()
    {
        velocity.Normalize();
        velocity *= speed;

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = velocity.x < 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving) {
            transform.Translate(velocity * Time.deltaTime);
            if (Mathf.Abs(transform.position.x) > 11 || Mathf.Abs(transform.position.y) > 11) {
                Destroy(this.gameObject);
            }
        }
    }

    public void die()
    {
        isMoving = false;
    }
}

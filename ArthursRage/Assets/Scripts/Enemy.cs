using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] private float speed;
    private Vector2 velocity;
    public bool isAlive = true;
    
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
        if (isAlive) {
            transform.Translate(velocity * Time.deltaTime);
            if (Mathf.Abs(transform.position.x) > 11 || Mathf.Abs(transform.position.y) > 11) {
                Destroy(this.gameObject);
            }
        }
    }

    public void die()
    {
        isAlive = false;
    }
}

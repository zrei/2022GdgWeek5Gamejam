using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] private float speed;
    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(-transform.position.x, -transform.position.y); 
        velocity.Normalize();
        velocity *= speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
    }
}

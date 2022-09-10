using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{
    [SerializeField] private float speed;
    public Vector2 velocity;
    
    public void setVelocity(Vector2 v) {
        velocity = v;
    }

    // Start is called before the first frame update
    void Start()
    {
        velocity.Normalize();
        velocity *= speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
    }
}

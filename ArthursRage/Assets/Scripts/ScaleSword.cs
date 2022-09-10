using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSword : MonoBehaviour
{
    private Transform transform;
    private int origScaleX;
    private int origScaleY; 

    public int maxEnem;
    public GameObject Sword;
    // Start is called before the first frame update
    
    void Awake()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

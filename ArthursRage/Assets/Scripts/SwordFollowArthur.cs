using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordFollowArthur : MonoBehaviour
{
    [SerializeField] private GameObject arthur;

    private float vertOffset;
    private float horiOffset;

    private Transform transform;

    void Awake() {
        transform = GetComponent<Transform>();
        horiOffset = arthur.transform.position.x - transform.position.x;
        vertOffset = arthur.transform.position.y - transform.position.y;
    }
    void Update()
    {
        //Vector3 localPosition = arthur.transform.position - transform.position;
        //localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.position = new Vector3(arthur.transform.position.x - horiOffset, arthur.transform.position.y - vertOffset, transform.position.z);
        //(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
    }
}

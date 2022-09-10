using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPosition : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3 (mouse.x, mouse.y,transform.position.z));
        Vector3 targetDirection = mouseWorld - transform.position;
        transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(-targetDirection.x, targetDirection.y) * Mathf.Rad2Deg,Vector3.forward);
    }
}

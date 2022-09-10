using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPosition : MonoBehaviour
{
    public GameObject Arthur;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3 (mouse.x, mouse.y,transform.position.z));
        Vector3 targetDirection = mouseWorld - Arthur.transform.position;
            // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;
        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.AngleAxis(-90 + Mathf.Atan2(newDirection.y, newDirection.x) * Mathf.Rad2Deg,Vector3.forward);
    }
}

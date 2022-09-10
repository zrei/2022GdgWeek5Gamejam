using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Countdown", animator.GetFloat("Countdown") + Time.deltaTime);
        if(animator.GetFloat("Countdown") > 2.1) animator.SetFloat("Countdown", 0f);
    }
}

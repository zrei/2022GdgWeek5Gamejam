using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwordInteraction : MonoBehaviour
{
    private Animator animator;
    void Awake()
    {
        //animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            //animator.SetBool("isDead", true);
            //Debug.Log(animator.GetCurrentAnimatorStateInfo(0).shortNameHash);
            //while(animator.GetCurrentAnimatorStateInfo(0).IsName("arthur_death")) {
//
  //          }
 
            //Debug.Log(animator.GetCurrentAnimatorStateInfo(0).name);
            
            
            Destroy(other.gameObject);
        }  else if (other.gameObject.CompareTag("Queen")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

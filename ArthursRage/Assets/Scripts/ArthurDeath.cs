using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArthurDeath : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            animator.SetTrigger("Death");
            this.GetComponent<ArthurMovement>().die();
        }
    }

    void Update() {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("arthur_dead")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

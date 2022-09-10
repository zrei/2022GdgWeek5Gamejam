using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class ArthurDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Debug.Log("You have died");
        } else if (other.gameObject.CompareTag("Queen")) {
            Debug.Log("You killed the queen :(");
        }
    }

}

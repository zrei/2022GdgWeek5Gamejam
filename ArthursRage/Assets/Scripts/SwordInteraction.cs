using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SwordInteraction : MonoBehaviour
{
    private int killed = 0;
    private Animator animator;
    public TMP_Text enemiesText;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            killed += 1;
            enemiesText.text = "Enemies Killed: " + killed;
            Destroy(other.gameObject);
        }
    }
}

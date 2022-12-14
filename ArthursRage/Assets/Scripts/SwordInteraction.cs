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

    //private int origScaleX;
    //private int origScaleY; 

    public int maxEnem;
    private int currExp = 0;
    public GameObject SwordParent;
    private Transform parentTransform;

    void Awake() {
        parentTransform = SwordParent.GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy") && other.gameObject.GetComponent<Enemy>().isAlive) {
            killed += 1;
            other.gameObject.GetComponent<Enemy>().die();
            other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            if (currExp < maxEnem) {
                currExp += 1;
                if (currExp % 3 == 0) {
                    parentTransform.localScale = new Vector3(parentTransform.localScale.x * 1.2f, parentTransform.localScale.y * 1.2f, parentTransform.localScale.z);
                }
            }
            enemiesText.text = "Enemies Killed: " + killed;
            GameObject.FindGameObjectWithTag("ScoreHolder").GetComponent<ScoreHolder>().setScore(killed);
        }
    }
}

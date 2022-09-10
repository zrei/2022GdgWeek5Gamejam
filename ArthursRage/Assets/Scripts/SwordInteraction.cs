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

    //public int maxEnem;
    public GameObject SwordParent;
    private Transform parentTransform;

    void Awake() {
        parentTransform = SwordParent.GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            killed += 1;
            parentTransform.localScale = new Vector3(parentTransform.localScale.x * 1.2f, parentTransform.localScale.y * 1.2f, parentTransform.localScale.z);
            enemiesText.text = "Enemies Killed: " + killed;
            Destroy(other.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreText : MonoBehaviour
{
    public TMP_Text finalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        int score = GameObject.FindGameObjectWithTag("ScoreHolder").GetComponent<ScoreHolder>().getScore();
        finalScoreText.text = "Final Score: " + score;
    }
}

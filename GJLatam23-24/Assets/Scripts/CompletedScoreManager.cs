using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


// This script glue a bunch of different things together
public class CompletedScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public float score;

    // Update is called once per frame
    public void Update()
    {
        // Add a little bit of score each frame
        score += Time.deltaTime;

        // And change the score text to reflect the new score! For good measure, we are also rounding the score to the nearest whole number
        scoreText.text = "Score: " + Mathf.Round(score);
    }
}

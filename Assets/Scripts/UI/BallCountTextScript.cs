using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCountTextScript : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Balls: " + SectionScoreScript.score.ToString() + " / " + SectionScoreScript.minimumScore.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreText : MonoBehaviour
{
    public Text totalScoreText;

    // Update is called once per frame
    void Update()
    {
        totalScoreText.text = "Total Score: " + PlayerPrefs.GetFloat("TotalScore", 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteKey("TotalScore");
        }
    }
}

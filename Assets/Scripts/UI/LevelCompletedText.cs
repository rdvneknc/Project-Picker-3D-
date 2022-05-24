using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompletedText : MonoBehaviour
{
    public Text levelCompleted;

    private void Start()
    {
        levelCompleted.text = "LEVEL COMPLETED!";
    }

    void Update()
    {
        
        if(GameManager.levelCompleted == true)
        {
            levelCompleted.gameObject.SetActive(true);
        }

        else
        {
            levelCompleted.gameObject.SetActive(false);
        }
    }

}

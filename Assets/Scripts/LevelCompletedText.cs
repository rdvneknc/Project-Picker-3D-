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

        //levelCompleted.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
        if(GameManager.levelCompleted == true)
        {
            levelCompleted.gameObject.SetActive(true);
        }

        if (GameManager.levelCompleted == false)
        {
            levelCompleted.gameObject.SetActive(false);
        }

    }

}

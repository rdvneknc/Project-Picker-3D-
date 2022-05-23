using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public static bool levelCompleted = false;

    private void Start()
    {

    }

    private void Update()
    {
        if (PlayerMovement.completedSectionCount >= 6 && SectionScoreScript.score >= SectionScoreScript.minimumScore)
        {
            levelCompleted = true;
        }

        if (levelCompleted == true)
        {

            PlayerMovement.movementEnabled = false;
            //new WaitForSeconds(3);
            SectionScoreScript.score = 0;   
        }

    }

    public void ContinueGame()
    {
        PlayerMovement.completedSectionCount = 0;
        new WaitForSeconds(2);
        levelCompleted = false;
        //BallGenerator.stopSpawning = false;
        //PlayerMovement.movementEnabled = true;
        //SectionGenerator.generateSection = false;

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static bool levelCompleted = false;

    private void Update()
    {
        if (PlayerMovement.completedSectionCount >= 12 && SectionScoreScript.score >= SectionScoreScript.minimumScore)
        {
            levelCompleted = true;
        }

        if (levelCompleted == true)
        {
            StopAllCoroutines();
            BallGenerator.stopSpawning = true;
            PlayerMovement.movementEnabled = false;
            new WaitForSeconds(3);
        }
    }


}

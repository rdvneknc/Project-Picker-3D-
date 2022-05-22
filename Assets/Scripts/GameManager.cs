using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static bool levelCompleted = false;

    private void Update()
    {
        if (PlayerMovement.completedSectionCount >= 12)
        {
            levelCompleted = true;
        }

        /*if (levelCompleted == true)
        {
            StopAllCoroutines();
            //SectionGenerator.generateSection = false;
            BallGenerator.stopSpawning = true;
            //ElevatorGenerator.generateElevator = false;
        }*/
    }

    public void LevelCompleted()
    {
        Debug.Log("LEVEL COMPLETED");
    }
}

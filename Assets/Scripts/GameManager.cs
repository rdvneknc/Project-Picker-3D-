using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool levelCompleted = false;

    private void Update()
    {
        if (PlayerMovement.completedSectionCount >= 15)
        {
            levelCompleted = true;
        }

        if (levelCompleted == true)
        {
            SectionGenerator.generateSection = false;
            BallGenerator.stopSpawning = true;
            ElevatorGenerator.generateElevator = false;
        }
    }
}

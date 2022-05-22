using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionScoreScript : MonoBehaviour
{
    private void Update()
    {
       // Debug.Log("Score: " + ElevatorController.score + "Minimum Score: " + ElevatorController.minimumScore);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ElevatorController.minimumScore += 5;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionScoreScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ElevatorController.minimumScore += 5;
        }
    }
}

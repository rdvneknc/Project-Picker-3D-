using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionStartScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SectionScoreScript.minimumScore += 5;
        }
    }
}

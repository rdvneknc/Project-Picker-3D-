using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorGenerator : MonoBehaviour
{
    public GameObject Elevator;
    public GameObject Player;

    private float zPosition = 124.5f;
    public static bool generateElevator = false;

    void Update()
    {
        if (generateElevator == false && GameManager.levelCompleted == false)
        {
            generateElevator = true;
            StartCoroutine(CreateElevator());
        }
    }

    IEnumerator CreateElevator()
    {
        Instantiate(Elevator, new Vector3(0, -0.5f, zPosition), Quaternion.identity);
        zPosition += 83;
        yield return new WaitForSeconds(15);
        generateElevator = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorGenerator : MonoBehaviour
{
    public GameObject Elevator;
    public GameObject Player;
    private float zPosition = 124.5f;
    public bool generateElevator = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (generateElevator == false && Player.transform.position.z >= Elevator.transform.position.z + 10)
        {
            generateElevator = true;
            StartCoroutine(CreateElevator());
        }
    }

    IEnumerator CreateElevator()
    {
        Instantiate(Elevator, new Vector3(0, -0.5f, zPosition), Quaternion.identity);
        zPosition += 83;
        yield return new WaitForSeconds(20);
        generateElevator = false;
        //BallGenerator.stopSpawning = false;
    }
}

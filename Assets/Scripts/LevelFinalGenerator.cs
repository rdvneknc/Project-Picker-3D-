using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinalGenerator : MonoBehaviour
{
    public GameObject Flag;
    public float flagZPosition = 40;
    public static bool generateFlag = false;

    void Update()
    {
        if (generateFlag == false)
        {
            generateFlag = true;
            StartCoroutine(CreateSection());
        }

    }

    IEnumerator CreateSection()
    {
        Instantiate(Flag, new Vector3(0, 2.38f, flagZPosition), Quaternion.identity);
        flagZPosition += 249;
        yield return new WaitForSeconds(30);
        generateFlag = false;
        BallGenerator.stopSpawning = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    public GameObject Section;
    public GameObject Player;

    public float zPosition = 83;
    public static bool generateSection = false;

    void Update()
    {
        if (generateSection == false)
        {
            generateSection = true;
            StartCoroutine(CreateSection());
        }
    }

    IEnumerator CreateSection()
    {
        Instantiate(Section, new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 83;

        BallGenerator.ballsPrefabCount += 3;
        //line for challenge level

        yield return new WaitForSeconds(15);

        generateSection = false;
        BallGenerator.stopSpawning = false;
    }
}

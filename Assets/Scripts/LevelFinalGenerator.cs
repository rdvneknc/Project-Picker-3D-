using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinalGenerator : MonoBehaviour
{
    public GameObject flag;
    public float flagZPosition = 40;
    public static bool generateFlag = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (generateFlag == false /*&& GameManager.levelCompleted == false*/)
        {
            generateFlag = true;
            StartCoroutine(CreateSection());
        }

    }

    IEnumerator CreateSection()
    {
        Instantiate(flag, new Vector3(0, 2.38f, flagZPosition), Quaternion.identity);
        flagZPosition += 249;
        yield return new WaitForSeconds(5);
        generateFlag = false;
        BallGenerator.stopSpawning = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject BallsPrefab;
    public GameObject SectionStart;
    public GameObject SectionFinish;

    public int ballsPrefabCount = 4;

    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateBalls", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void LateUpdate()
    {

    }
    void CreateBalls()
    {
        Vector3 randomBallPosition = new Vector3(Random.Range(-3.5f, 3.5f), 1.7f, Random.Range(SectionStart.transform.position.z, SectionFinish.transform.position.z));

        for (int i = 0; i < ballsPrefabCount; i++)
        {
            Instantiate(BallsPrefab, randomBallPosition, Quaternion.identity);
            if(stopSpawning == false)
            {
                CancelInvoke("CreateBalls");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject BallsPrefab;
    public GameObject SectionStart;
    public GameObject SectionFinish;

    public static int ballsPrefabCount = 3;

    public static bool stopSpawning = true;
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
        if (stopSpawning == false)
        {
            for (int i = 0; i < ballsPrefabCount; i++)
            {
                Instantiate(BallsPrefab, new Vector3(Random.Range(-3f, 3f), 1.8f, Random.Range(SectionStart.transform.position.z, SectionFinish.transform.position.z)), Quaternion.identity);
                
                if(stopSpawning == false)
                {
                    CancelInvoke("CreateBalls");
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDelay : MonoBehaviour
{
    public static bool gameStarting = false;
    void Start()
    {
        StartCoroutine("DelayStart");
    }

    IEnumerator DelayStart()
    {
        gameStarting = true;
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;

        gameStarting = false;
        Time.timeScale = 1;

    }
}

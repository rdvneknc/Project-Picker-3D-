using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{  
    public static bool levelCompleted = false;

    private void Update()
    {
        if (PlayerMovement.completedSectionCount >= 12 && SectionScoreScript.score >= SectionScoreScript.minimumScore)
            //  Player'� 3 cube kullanarak amat�rce haz�rlad���m i�in �zerinde 3 collider var. Finish line'� her ge�ti�inde
            // completedSectionCount 3 olarak art�yor. Bu nedenle yukar�daki 12 asl�nda 4 section tamamland���n� g�steriyor.
        {
            levelCompleted = true;
        }

        if (levelCompleted == true)
        {
            PlayerMovement.movementEnabled = false;
            SectionScoreScript.score = 0;   
        }


    }

    public void ContinueGame()
    {
        PlayerMovement.completedSectionCount = 0;
        new WaitForSeconds(2);
        levelCompleted = false;
        PlayerMovement.movementEnabled = true;

    }


}

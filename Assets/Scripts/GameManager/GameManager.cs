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
        if (PlayerMovement.completedSectionCount >= 9 && SectionScoreScript.score >= SectionScoreScript.minimumScore)
            //  Player'ý 3 cube kullanarak amatörce hazýrladýðým için üzerinde 3 collider var. Finish line'ý her geçtiðinde
            // completedSectionCount 3 olarak artýyor. Bu nedenle yukarýdaki 9 aslýnda 3 section tamamlandýðýný gösteriyor.
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

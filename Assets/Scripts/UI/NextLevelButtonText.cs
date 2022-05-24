using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelButtonText : MonoBehaviour
{
    public Button nextLevelButton;

    void Update()
    {
        if (GameManager.levelCompleted == true)
        {
            nextLevelButton.gameObject.SetActive(true);
        }

        if (GameManager.levelCompleted == false)
        {
            nextLevelButton.gameObject.SetActive(false);
        }
    }

 
}

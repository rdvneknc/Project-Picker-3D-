using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetReadyTextScript : MonoBehaviour
{
    public TextMeshProUGUI getReadyText;

    private void Start()
    {
        getReadyText.text = "GET READY!";
    }

    // Update is called once per frame
    void Update()
    {
        if (StartDelay.gameStarting == true)
        {
            getReadyText.gameObject.SetActive(true);
        }

        else
        {
            getReadyText.gameObject.SetActive(false);
        }
    }
}

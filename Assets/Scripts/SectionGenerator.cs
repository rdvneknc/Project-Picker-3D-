using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    public GameObject Section;
    public GameObject Player;
    public float zPosition = 83;
    public float yPosition = 0;
    public bool generateSection = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        yield return new WaitForSeconds(20);
        generateSection = false;
        BallGenerator.stopSpawning = false;
    }
}

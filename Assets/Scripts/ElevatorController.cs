using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public Rigidbody rbElevator;

    void Awake()
    {
        rbElevator.GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {

        if (SectionScoreScript.score >= SectionScoreScript.minimumScore)
        {
            StartCoroutine(WaitForMovement());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            SectionScoreScript.score += 1;
            SectionScoreScript.totalScore += 1;
            Destroy(other.gameObject);
        }
    }

    IEnumerator WaitForMovement()
    {
        Vector3 liftElevator = new Vector3(transform.position.x, 0, transform.position.z);

        //yield return new WaitForSeconds(1);

        rbElevator.MovePosition(liftElevator);

        yield return new WaitForSeconds(2);

        SectionScoreScript.score = 0;

        PlayerMovement.movementEnabled = true;
    }
}

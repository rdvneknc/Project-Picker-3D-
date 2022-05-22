using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public static float score = 0;
    public static float minimumScore = 10;
    public Rigidbody rbElevator;
    // Start is called before the first frame update
    void Start()
    {
        rbElevator.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Minimum:" + minimumScore + "Score:" + score);
        
    }

    private void FixedUpdate()
    {

        if (score >= minimumScore)
        {
            StartCoroutine(WaitForMovement());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            score += 1;
            Destroy(other.gameObject);
            

        }
    }

    IEnumerator WaitForMovement()
    {
        Vector3 liftElevator = new Vector3(transform.position.x, 0, transform.position.z);

        yield return new WaitForSeconds(1);

        //rbElevator.velocity = new Vector3(transform.position.x, 0.1f, transform.position.z);

        rbElevator.MovePosition(liftElevator);

        yield return new WaitForSeconds(2);

        //rbElevator.constraints = RigidbodyConstraints.FreezePositionY;

        score = 0;

        PlayerMovement.movementEnabled = true;
    }
}

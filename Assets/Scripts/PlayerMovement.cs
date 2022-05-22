using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float verticalSpeed;
    public float horizontalSpeed;

    public static bool movementEnabled = true;

    public static int completedSectionCount;

    private void Awake()
    {
        rb.GetComponent<Rigidbody>();
    }
    void Start()
    {

    }

    private void Update()
    {
        Debug.Log("Copleted Section: " + completedSectionCount);

    }

    void FixedUpdate()
    {

        if (movementEnabled == true)
        {
            rb.velocity = new Vector3(0, 0, 5) * verticalSpeed;
        }

        Vector3 xMovement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        rb.MovePosition(transform.position + xMovement * horizontalSpeed);

        if (transform.position.x >= 3.96f)
        {
            transform.position = new Vector3(3.96f, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= -3.96f)
        {
            transform.position = new Vector3(-3.96f, transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SectionFinish")
        {
            movementEnabled = false;
            completedSectionCount += 1;
        }
    }

}

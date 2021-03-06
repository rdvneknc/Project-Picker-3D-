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

        
        Vector3 stablePositionY = new Vector3(transform.position.x, 1.66f, transform.position.z);

        if (transform.position.y <= 1.62f || transform.position.y>= 1.72f)
        {
            transform.position = stablePositionY;
        }
        //  Section ge?i?lerinde Player'?n Y pozisyonu de?i?ti?i i?in tak?lma sorunu ya??yordu, sorunu d?zeltene kadar
        // ge?ici olarak yukar?daki kodu ekledim


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SectionFinish")
        {
            movementEnabled = false;
            completedSectionCount += 1;
        }

        if(other.gameObject.tag == "SectionStart")
        {
            SectionScoreScript.score = 0;
        }
    }

}

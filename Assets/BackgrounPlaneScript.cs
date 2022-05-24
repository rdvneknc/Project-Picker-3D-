using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrounPlaneScript : MonoBehaviour
{

    public Plane backgroundPlane;
    public Color backgroundPlaneColor;

    void Start()
    {
        GetComponent<Renderer>().material.color = Plane.planeColor;
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAi : MonoBehaviour
{
    private Vector3 moveDiraction;
    public Rigidbody rb;
    public float thrust = 10f;

    public float randomNumberz = 100f;


    static void getNewPos()
    {

    }
    void Update()
    {
        rb.AddRelativeForce(Vector3.forward * thrust);


    }
}

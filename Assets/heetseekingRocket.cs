using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class heetseekingRocket : MonoBehaviour
=======
public class rocket : MonoBehaviour
>>>>>>> cdfe9d19705fd336e1fce3bf2b5304bdd56eca76
{

    [SerializeField] private Transform enemy;
    [SerializeField] private float force;
    [SerializeField] private float rotationForce;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        Vector3 richting = enemy.position - rb.position;
        richting.Normalize();
        Vector3 rotatie = Vector3.Cross(transform.forward, richting);
        rb.angularVelocity = rotatie * rotationForce;
        rb.velocity = transform.forward * force;
    }
}

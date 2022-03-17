using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class kogel : MonoBehaviour
{

    [SerializeField] private Vector3 _rotation;

    public int health = 100;
    public float thrust = 1.0f;
    public Rigidbody rb;
    public int xje = 0;
    public int yje = 0;
    public int zje = 0;
    // Start is called before the first frame update
    void Start()
    {


        transform.position += transform.forward;
        gameObject.transform.Rotate(_rotation = new Vector3(xje, 270, zje));
    }

    // Update is called once per frame
    void Update()
    {



        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * thrust);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

    }
}
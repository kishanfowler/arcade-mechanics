using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 20;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s"))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.forward, speed * Time.deltaTime);

        }

        if (Input.GetKey("d"))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + transform.right, speed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.right, speed * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + transform.forward, speed * Time.deltaTime);
        }
    }
}

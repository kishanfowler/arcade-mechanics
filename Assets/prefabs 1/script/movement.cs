using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    public float speed = 10;
    public float RotationSpeed = 10;
    public GameObject cameraPivot = null;
    public Rigidbody rb = null;
    public float thrust = 10f;
    public int begrondt = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (begrondt >= 1)
            {
                begrondt -= 1;
                rb.AddForce(new Vector3(0, thrust, 0));
            }

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cameraPivot.transform.Rotate(_rotation = new Vector3(0f, 0.0f, -0.1f * Time.deltaTime * RotationSpeed));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            cameraPivot.transform.Rotate(_rotation = new Vector3(0f, 0.0f, 0.1f * Time.deltaTime * RotationSpeed));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(_rotation = new Vector3(0f, 0.1f * Time.deltaTime * RotationSpeed, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(_rotation = new Vector3(0f, -0.1f * Time.deltaTime * RotationSpeed, 0));
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        begrondt = 2;
    }
}

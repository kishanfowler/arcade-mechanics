using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb = null;
    public float moveSpeed;
    //public Rigidbody theRB;
    public float jumpForce;
    static public CharacterController controller;

    private Vector3 moveDiraction;
    public float gravityScale;
    static public int grounded = 2;
    static public int grounded1 = 2;
    public int jumped = 1;
    // Start is called before the first frame update
    void Start()
    {
        //thRB = GetComponent<RigidBody>();
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        /*if(Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        }*/

        //moveDiraction = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDiraction.y, Input.GetAxis("Vertical") * moveSpeed);
        float yStore = moveDiraction.y;
        moveDiraction = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        
        moveDiraction = moveDiraction.normalized * moveSpeed;
        moveDiraction.y = yStore;
        if (Input.GetButtonDown("Jump") && grounded == 1 || (Input.GetButtonDown("Jump") && grounded == 2))
        {
            jumped = 2;
            moveDiraction.y = jumpForce;
            grounded -= 1;
            grounded1 -= 1;
            
            print(Beweeg.grounded1);
        }
        if (controller.isGrounded)
        {
            jumped = 1;
            if (grounded == 1)
            {
                moveDiraction.y = 0;
            }

            grounded = 1;
            grounded1 = 2;
            playAnimation.JumpedOrNot = 1;
        }
        moveDiraction.y = moveDiraction.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDiraction * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllertje : MonoBehaviour{

    public float moveSpeed;
    //public Rigidbody theRB;
    public float jumpForce;
    public CharacterController controller;

    private Vector3 moveDiraction;
    public float gravityScale;  
    
    // Start is called before the first frame update
    void Start() {
        //thRB = GetComponent<RigidBody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
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

        if (controller.isGrounded)
        {
            moveDiraction.y = 0f;

            if (Input.GetButtonDown("Jump"))
            {
                moveDiraction.y = jumpForce;
            }
        }
        moveDiraction.y = moveDiraction.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDiraction * Time.deltaTime);
    }
}

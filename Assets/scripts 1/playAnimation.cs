using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{

    [SerializeField] ParticleSystem walk_Jump = null;

    public Animator AnimRefObj;
    static public int JumpedOrNot = 0;
    public int walkedOrNot = 1;
    public int allreadyPlaying = 1;
    public int allreadyPlayingPlaying = 1;
    public int allreadyPlayingPlayingPlaying = 1;
    public int Jumppress = 1;
    public int GrouNded = 1;
    static public bool Jump = false;

    void Start()
    {
        walk_Jump.Stop();
        AnimRefObj = GetComponent<Animator>();
    }

    void Update()
    {

        // zelfde maar dan met lopen, misschien moet ik ook links en rechts animaties maken
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            while (Beweeg.controller.isGrounded)
            {
                AnimRefObj.Play("walk");
                walk_Jump.Play();

                if (Input.GetButtonDown("Jump") && JumpedOrNot == 2)
                {
                    walk_Jump.Stop();
                }

            }

        }


        // check of jump button is pressed en dan checken of het kan, dan runnen.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(JumpedOrNot <= 2)
            {
                JumpedOrNot += 1;
                AnimRefObj.Play("Jump");
            }
            
            
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        JumpedOrNot = 0;
    }





}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{

    [SerializeField] ParticleSystem walk_Jump = null;

    public Animator AnimRefObj;
    static public int JumpedOrNot = 1;
    public int walkedOrNot = 1;
    public int allreadyPlaying = 1;
    public int allreadyPlayingPlaying = 1;
    public int allreadyPlayingPlayingPlaying = 1;
    public int Jumppress = 1;
    public int GrouNded = 1;

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
            if (JumpedOrNot == 1)
            {
                AnimRefObj.Play("walk");
                walk_Jump.Play();
            }
            


        }


        // check of jump button is pressed en dan checken of het kan, dan runnen.
        if (Input.GetButtonDown("Jump"))
        {
            JumpedOrNot = 2;

            
            if (JumpedOrNot >= 2)
            {
                AnimRefObj.Play("Jump");
            }
            if (JumpedOrNot == 2)
            {
                JumpedOrNot = 3;
            }
        }


    }





}

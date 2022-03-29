using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textverandering : MonoBehaviour
{
    
    public Text txt;
    public GameObject txtje;
    public int vaakgelopen = 1;
    public int geschoten = 1;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = " ";
        txt.text = "b";
    }

    // Update is called once per frame
    void Update()
    {

        txt.text = geschoten.ToString();
        
       // if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        //{
          //  txt.text = "Dit is de userstory: Lopen";
            // vaakgelopen += 1;
           // geschoten = 0;
       // }
       //else
        //{
         //   vaakgelopen = 1;
       // }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
           // txt.text = "Dit is de userstory: Jump";
           // geschoten = 0;
        //}
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
            
            // geschoten += 1;
        //}
        

        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            txt.text = "Dit is de userstory: Lopen";
            // vaakgelopen += 1;
            geschoten = 0;
        }
        else
        {
            vaakgelopen = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            txt.text = "Dit is de userstory: Jump";
            geschoten = 0;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            txt.text = "Dit is de userstory: schieten";
            // geschoten += 1;
        }

    }
}

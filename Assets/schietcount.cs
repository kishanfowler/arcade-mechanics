using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class schietcount : MonoBehaviour
{
    static public bool jaofnee;
    public Text txt;
    public GameObject txtje;
    public int vaakgelopen = 1;
    static public int geschoten = 7;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = " ";
        

    }

    // Update is called once per frame
    void Update()
    {
        
        
        txt.text = " " + geschoten + "/" + "7";

        if (Input.GetKeyDown(KeyCode.Mouse0) && geschoten != 0 && jaofnee == true)
        {
            
            txt.text = " " + geschoten + "/" + "7";

        }




    }
}

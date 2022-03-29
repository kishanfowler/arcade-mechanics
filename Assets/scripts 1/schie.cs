using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schie : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    public int height = 4;
    public GameObject objectA;

    public GameObject Gun;

    public GameObject objectB;

    public GameObject objectC;
    public GameObject objectD;
    public static string SetActive = "true";
    [SerializeField] private Vector3 _rotation;


    // Update is called once per frame
    private void Update()
    {

        Gun.transform.rotation = objectD.transform.rotation;
        objectC.transform.rotation = Gun.transform.rotation;
        Gun.transform.Rotate(_rotation = new Vector3(270.019775f, 180, 0));
        objectC.transform.Rotate(_rotation = new Vector3(180, 180, 90));

        objectB.transform.rotation = objectD.transform.rotation;
        objectC.transform.rotation = objectB.transform.rotation;
        objectB.transform.Rotate(_rotation = new Vector3(-90, 180, 270));
        objectC.transform.Rotate(_rotation = new Vector3(90, 180, 90));

        if (SetActive == "true")
        {

            if (Input.GetKeyDown("r"))
            {
                schietcount.geschoten = 7;
            }
            if (Input.GetMouseButtonDown(0) && schietcount.geschoten != 0)
            {
                Instantiate(block, transform.position, transform.rotation);
                schietcount.geschoten -= 1;
                
            }
        }
        else
        {
            schietcount.jaofnee = false;
        }


    }
}


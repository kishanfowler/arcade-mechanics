using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schiet1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public GameObject block;
    public int width = 10;
    public int height = 4;
    public GameObject objectA;
    public GameObject objectB;
    public GameObject objectC;
    public GameObject objectD;
    public static string SetActive = "true";
    [SerializeField] private Vector3 _rotation;


    // Update is called once per frame
    void Update()
    {
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieter : MonoBehaviour
{
    public GameObject kogel = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Instantiate(kogel, transform.position, transform.rotation);
        }
    }
}

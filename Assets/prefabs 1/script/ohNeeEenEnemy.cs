using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ohNeeEenEnemy : MonoBehaviour
{
    public GameObject wordtparent = null;
    public GameObject wordtkind = null;

    public float Health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Health -= 50;

        }
        if (collision.collider.tag == "Enemy") { 
            if (Health >= 0)
            {
                // wordtkind.transform.parent = null;
                Destroy(gameObject);
            }
        }
    }

}

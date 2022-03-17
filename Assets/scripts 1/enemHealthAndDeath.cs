using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemHealthAndDeath : MonoBehaviour
{
    public int Health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "Bullet" && Health >= 0)
        {
            
            Health -= 10;
                        
            GetComponent<Renderer>().material.color = new Color(0.220f, 0.20f, 0.60f); //C#
            if (Health == 0)
            {
                
                Destroy(gameObject);
                
            }
            
            
        }

    }
}

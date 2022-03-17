using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raket : MonoBehaviour
{
    private GameObject Enemy;
    public Rigidbody rb = null;
    public int graai = 1;
    private void Start()
    {
        Enemy = GameObject.FindWithTag("Enemy");
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Enemy.transform);
        transform.position += transform.forward * Time.deltaTime * 10;
        
        
    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.collider.tag != "Bullet")
        {
            Destroy(gameObject);
        }

        
    }
}

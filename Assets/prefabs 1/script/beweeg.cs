using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class beweeg : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject a = null;
    public GameObject b = null;
    public float bx = 0;
    public float by = 0;
    public float bz = 0;

    public float ax = 0;
    public float ay = 0;
    public float az = 0;

    public float eindx = 0;
    public float eindy = 0;
    public float eindz = 0;
    public int ja = 1;
    GameObject asA;
    GameObject asB;
    GameObject A;
    GameObject B;
    float n = 0f;
    public float speed = 0.01f;
    void Start()
    {
        ax = a.transform.position.x;
        ay = a.transform.position.x;
        az = a.transform.position.x;
        bx = b.transform.position.x;
        by = b.transform.position.x;
        bz = b.transform.position.x;
        
        transform.position = b.transform.position;
        eindx = ax -= bx;
        eindy = ay -= by;
        eindz = az -= bz;
        eindx /= 20;
        eindy /= 20;
        eindz /= 20;

        A = GameObject.Find("vector1");
        B = GameObject.Find("enB");




    }

    // Update is called once per frame
    void Update()
    {
        //if (ja == 1)
        //{
        //    transform.position += new Vector3(eindx, 0, 0) * Time.deltaTime;
        //}
        //if (transform.position.x == 130)
        //{
        //     ja = 2;
        //}
        //if (ja == 2)
        //{
        //    transform.position -= new Vector3(eindx, 0, 0) * Time.deltaTime;
        //}
        // if (transform.position.x >= -10)
        //{
        //ja = 1;
        //}

        transform.position = B.transform.position + n * (A.transform.position - B.transform.position);

        n += speed;
        if (n > 1)
        {
            speed = -Mathf.Abs(speed);
        }



        if (n < 0)
        {
            speed = Mathf.Abs(speed);
        }
    }
}

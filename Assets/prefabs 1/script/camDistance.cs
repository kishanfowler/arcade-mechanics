using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camDistance : MonoBehaviour
{
    public float camspeed = 1.1f;
    public float bezig = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bezig == 2)
        {
            StartCoroutine(keer(0.1f));
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            bezig = 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            bezig = 1;
            camspeed = 1.1f;
        }
                if (bezig == 2)
        {
            StartCoroutine(keer(0.1f));
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            bezig = 2;
        }
        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            bezig = 1;
            camspeed = 1.1f;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position += transform.forward * Time.deltaTime * 0.25f * camspeed;
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            transform.position -= transform.forward * Time.deltaTime  * 0.25f * camspeed;
        }
    }
    IEnumerator keer(float time)
    {

        yield return new WaitForSeconds(time);
        camspeed += 0.1f;



    }
}

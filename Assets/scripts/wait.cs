using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class wait : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 _rotation;
    public float yas = 1f;
    public float smooth = 1;
    public float yas1 = 1;
    public float go = 1;
    void Start()
    {
        
        StartCoroutine(JustWait(1));
    }

    // Update is called once per frame
    void Update()
    {







    }

    IEnumerator JustWait(float time)
    {
        if (go == 1)
        {
            yield return new WaitForSeconds(time);
            Debug.Log("hoi");
            yas = Random.Range(0f, 360f);
            rando();


        }
        else
        {
            yield return new WaitForSeconds(time);
            rando();
        }


    }

    void rando()
    {
        go = 2;


        if (yas >= smooth)
        {
            gameObject.transform.Rotate(_rotation = new Vector3(0, 1, 0));
            smooth += 1;
            StartCoroutine(nogniet(0.01f));

        }
        
        
        else
        {
            go = 1;
            smooth = 1;
            StartCoroutine(JustWait(4));
        }

    }
    IEnumerator nogniet(float time)
    {
        yield return new WaitForSeconds(time);
        rando();



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meelee : MonoBehaviour
{
    public kogel kogel;
    public GameObject sword;
    public bool kanMeelee = true;
    public float cooldown = 1.0f;
    public bool valtAan = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (kanMeelee)
            {
                meeleeAanval();
            }
        }
    }

    public void meeleeAanval()
    {
        kanMeelee = false;
        schiet1.SetActive = "false";
        valtAan = true;
        StartCoroutine(resetCooldown());
    }

    IEnumerator resetCooldown()
    {
        StartCoroutine(resetAanval());
        yield return new WaitForSeconds(cooldown);
        kanMeelee = true;
    }

    IEnumerator resetAanval()
    {
        yield return new WaitForSeconds(1.0f);
        valtAan = false;
    }
}

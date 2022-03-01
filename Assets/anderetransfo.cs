using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anderetransfo : MonoBehaviour
{

    public GameObject player;
    public float ypos = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ypos = player.transform.position.y;
        ypos += 2;
        transform.position = new Vector3(player.transform.position.x,ypos,player.transform.position.z);
       
    }
}

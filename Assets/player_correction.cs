using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_correction : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    public GameObject camTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = camTarget.transform.rotation;
    }
}

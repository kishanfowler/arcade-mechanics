using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wapenPickup : MonoBehaviour
{
    public Cylinder1 gunScript;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, weaponHolder, Camera;

    public bool equipped;
    public static bool slotFull;

    public float pickupRange;
    public float dropForwardForce, dropUpwardForce;

    private void pickup()
    {
        equipped = true;
        slotFull = true;

        transform.SetParent(weaponHolder);
        transform.localPosition = vector3.zero;
        transform.localRotation = Quaternion.Euler(vector3.zero);
        transform.localScale = vector3.one;

        rb.isKinematic = true;
        coll.isTrigger = true;

        gunScript.enabled = true;
    }

    private void drop()
    {
        equipped = false;
        slotFull = false;

        transform.SetParent(null);

        rb.isKinematic = false;
        coll.isTrigger = false;

        rb.velocity = player.GetComponent<RigidBody>().velocity;

        rb.AddForce(Camera.forward * dropForwardForce, ForceMode.Impulse);
        rb.AddForce(Camera.up * dropUpwardForce, ForceMode.Impulse);

        gunScript.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!equipped)
        {
            gunScript.enabled = false;
            rb.isKinematic = false;
            coll.isTrigger = false;
        }
        if (equipped)
        {
            gunScript.enabled = true;
            rb.isKinematic = true;
            coll.isTrigger = true;
            slotFull = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 afstandNaarSpeler = player.position - transform.position;
        if (!equipped && afstandNaarSpeler.magnitude <= pickupRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
            pickup();

        if (equipped && Input.GetKeyDown(KeyCode.Q))
        {
            drop();
        }
    }

}

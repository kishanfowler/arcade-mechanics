using UnityEngine;

public class WapenSwitch : MonoBehaviour
{
    public int geselecteerdWapen = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelecteerWapen();
    }

    // Update is called once per frame
    void Update()
    {

        int vorigGeselecteerdWapen = geselecteerdWapen;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (geselecteerdWapen >= transform.childCount - 1)
                geselecteerdWapen = 0;
            else
                geselecteerdWapen++;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (geselecteerdWapen <= 0)
                geselecteerdWapen = transform.childCount - 1;
            else
                geselecteerdWapen--;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            geselecteerdWapen = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            geselecteerdWapen = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 3)
        {
            geselecteerdWapen = 2;
        }

        if (vorigGeselecteerdWapen != geselecteerdWapen)
        {
            SelecteerWapen();
        }
    }

    void SelecteerWapen ()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == geselecteerdWapen)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }

}

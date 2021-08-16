using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_controller : MonoBehaviour
{
    //GameObject mainCamera;
    public bool carrying;
    GameObject carriedObject;
    Camera mainCam;
    public float smooth;
    public float distance;
    int x;
    int y;

    // Start is called before the first frame update
    void Start()
    {
        carrying = false;
        mainCam = Camera.main;
        x = Screen.width/2;
        y = Screen.height/2;

    }

    // Update is called once per frame
    void Update()
    {
        if (carrying)
        {
            Carry(carriedObject);
            rotateObject();
            CheckDrop();
        }
        else
            Pickup();
    }

    void rotateObject()
    {
        carriedObject.transform.Rotate(5, 10, 15);
    }
    void Carry(GameObject o)
    {
        Debug.Log(o.name);
        o.transform.position = Vector3.Lerp(o.transform.position, mainCam.transform.position + mainCam.transform.forward * distance, Time.deltaTime * smooth);
        o.transform.rotation = Quaternion.identity;
    }

    void Pickup()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = mainCam.ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                string tag = hit.collider.tag;
                Debug.Log(tag);
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if (p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    p.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    p.gameObject.GetComponent<displayUI>().displayInfo = false;
                }
            }
        }
    }

    void CheckDrop()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DropObject();
        }
    }

    void DropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
        carriedObject = null;
    }
}
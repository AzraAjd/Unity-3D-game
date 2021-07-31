using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_controller : MonoBehaviour   
{
    //GameObject mainCamera;
    bool carrying;
    GameObject carriedObject;
    Camera mainCam;
    public float distance;
    int x;
    int y;

    float smooth = 5.0f;
    float tiltAngle = 60.0f;


    // Start is called before the first frame update
    void Start()
    {
        //mainCamera = GameObject.FindWithTag("MainCamera");
        mainCam = Camera.main;
        x = Screen.width / 2;
        y = Screen.height / 2;

    }

    // Update is called once per frame
    void Update()
    {
        if (carrying)
        {
            carry(carriedObject);
            checkDrop();
        }  
        else
            pickup();
    }

    void carry (GameObject o)
    {
       o.transform.position = mainCam.transform.position + mainCam.transform.forward * distance;
    }

    void pickup()
    {
        if (Input.GetKeyDown(KeyCode.E)){

            Ray ray = mainCam.ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                string tag = hit.collider.tag;
                Debug.Log(tag);
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if (p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    //p.transform.Rotate(90.0f, 0, 0, Space.Self);
                    // p.transform.rotation = mainCam.transform.rotation;

                    /*p.transform.LookAt(mainCam.transform.position);
                    var rot = transform.rotation.eulerAngles;
                    p.transform.rotation = Quaternion.Euler(rot.x, rot.y, 0);*/

                }

               
            }
        }
    }

    void checkDrop()
    {
        if (Input.GetKeyDown (KeyCode.E))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
       //carriedObject.transform.Rotate(-90.0f, 0, 0, Space.Self);
        carriedObject = null;
    }
}

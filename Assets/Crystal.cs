using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    private GameObject rightDoor;
    private GameObject leftDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //action on player colliding with an object
    /*void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Debug.Log("player hit the crystal");
        }
    }*/

   /* void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player")
         {
            rightDoor = GameObject.Find("_Level/doorRight1");
            leftDoor = GameObject.Find("_Level/doorLeft1");
            rightDoor.GetComponent<Animator>().enabled = true;
            leftDoor.GetComponent<Animator>().enabled = true;
        }
    }*/


    private void OnTriggerEnter(Collider col)
    {
        rightDoor = GameObject.Find("_Level/doorRight1");
        leftDoor = GameObject.Find("_Level/doorLeft1");
        rightDoor.GetComponent<Animator>().enabled = true;
        leftDoor.GetComponent<Animator>().enabled = true;
    }
}

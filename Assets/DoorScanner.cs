using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScanner : MonoBehaviour
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

    void OnCollisionEnter(Collision dataFromCollision)
    {
        if (dataFromCollision.gameObject.name == "Chip")
        {
            rightDoor = GameObject.Find("_Level/doorRight1");
            leftDoor = GameObject.Find("_Level/doorLeft1");
            rightDoor.GetComponent<Animator>().enabled = true;
            leftDoor.GetComponent<Animator>().enabled = true;
        }
    }
}


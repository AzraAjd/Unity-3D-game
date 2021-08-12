using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScanner : MonoBehaviour
{
    private GameObject rightDoor;
    private GameObject leftDoor;
    private Animation rightDoorAnimation;
    private Animation leftDoorAnimation;
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

            rightDoorAnimation = rightDoor.GetComponent<Animation>();
            leftDoorAnimation = leftDoor.GetComponent<Animation>();

            rightDoorAnimation.Play("right_door");
            leftDoorAnimation.Play("left_door");

            StartCoroutine("StopAnimation");
        }
    }

    IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(5);
        rightDoorAnimation.Stop();
        leftDoorAnimation.Stop();
    }
}


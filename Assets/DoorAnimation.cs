using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    //for opening door from the first room, chip scanner is used; this (door open on collision),
    //works only for going back into the room

    private Animation rightDoorAnimation;
    private Animation leftDoorAnimation;

    // Start is called before the first frame update
    void Start()
    {
        rightDoorAnimation =  GameObject.Find("doorRight1").GetComponent<Animation>();
        leftDoorAnimation = GameObject.Find("doorLeft1").GetComponent<Animation>();
    }

    private void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.name == "Player")
        {
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

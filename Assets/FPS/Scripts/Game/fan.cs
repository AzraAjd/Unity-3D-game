using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        /*if (collision.gameObject.tag == "Player")
        {*/
            player = GameObject.Find("Player");
            player.GetComponent<Animator>().enabled = true;

       // }
    }
}

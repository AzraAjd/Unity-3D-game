using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private bool _isTouched = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_isTouched);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Crystal")
        {
            _isTouched = true;
        }
    }


    /* private void OnTriggerEnter(Collider col)
     {
         _isTouched = true;
         Debug.Log("hi");
     }*/
}

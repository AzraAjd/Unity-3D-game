using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFan : MonoBehaviour
{
    private Lever lever;
    public GameObject affectedFan;

    // Start is called before the first frame update
    void Start()
    {
        lever = GameObject.Find(affectedFan.name).GetComponent<Lever>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            lever.enabled = true;
            Debug.Log("lever enabled");
        }
    }
}

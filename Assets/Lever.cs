using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lever : MonoBehaviour
{
    public string affectedFan;
    private GameObject obj;
    private Turn_Move turn_move;
    private GameObject donut;


    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find(this.name+"/Fan_01/Fan_Wings_01");
        turn_move = obj.GetComponent<Turn_Move>();
        turn_move.TurnedOff = true;

        donut = GameObject.Find("Donut");
        //donut.transform.position = new Vector3(-1.38, 3.04, -7.48);
        donut.GetComponent<Animator>().enabled = false;
        donut.transform.position = new Vector3(-1.38f, 3.04f, -7.48f);
        //child = obj.transform.GetChild(0).gameObject;


    }

    // Update is called once per frame
    void Update()
    {

    }

}

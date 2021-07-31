using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Move : MonoBehaviour {
	public int TurnX;
	public int TurnY;
	public int TurnZ;

	public int MoveX;
	public int MoveY;
	public int MoveZ;

	public bool World;
	public bool TurnedOff = false;
	private float slowDownForce = 10.0f;
	//IEnumerator coroutine;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() {
		if (TurnedOff == false)
		{
			if (World == true)
			{
				transform.Rotate(TurnX * Time.deltaTime, TurnY * Time.deltaTime, TurnZ * Time.deltaTime, Space.World);
				transform.Translate(MoveX * Time.deltaTime, MoveY * Time.deltaTime, MoveZ * Time.deltaTime, Space.World);
			}
			else
			{
				transform.Rotate(TurnX * Time.deltaTime, TurnY * Time.deltaTime, TurnZ * Time.deltaTime, Space.Self);
				transform.Translate(MoveX * Time.deltaTime, MoveY * Time.deltaTime, MoveZ * Time.deltaTime, Space.Self);
			}
			
		}
		else
		{

			if (World == true)
			{
				transform.Rotate(TurnX * Time.deltaTime, TurnY * Time.deltaTime, slowDownForce * Time.deltaTime, Space.World);
				transform.Translate(MoveX * Time.deltaTime, MoveY * Time.deltaTime, MoveZ * Time.deltaTime, Space.World);
			}
			else
			{
				transform.Rotate(TurnX * Time.deltaTime, TurnY * Time.deltaTime, slowDownForce * Time.deltaTime, Space.Self);
				transform.Translate(MoveX * Time.deltaTime, MoveY * Time.deltaTime, MoveZ * Time.deltaTime, Space.Self);
			}
			/*coroutine = SlowlyStopProp();
			StartCoroutine(coroutine);*/
		}
	}
	/*public IEnumerator SlowlyStopProp()
	{
		float zAngle = -10.0F;
		while (true)
		{
			// no longer rotating, end coroutine
			if (zAngle == 0.0F)
			{
				yield break;
			}

			transform.Rotate(0, zAngle, 0);
			zAngle += 0.5F;
			yield return null;
		}
	}*/
}

using UnityEngine;
using System.Collections;

public class Hunter_Move : MonoBehaviour
{
	public float moveSpeed = 500f;
	public float turnSpeed = 30f;
	
	
	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (-Vector3.right * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
	}
}

using UnityEngine;
using System.Collections;

public class Duck_Move : MonoBehaviour
{
	public float moveSpeed = 100f;
	public float turnSpeed = 30f;
	public float fallSpeed = 500f


	void Update ()
	{
		if (Input.GetKey (KeyCode.Space))
			transform.Translate (Vector3.down * fallSpeed * Time.deltaTime);

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

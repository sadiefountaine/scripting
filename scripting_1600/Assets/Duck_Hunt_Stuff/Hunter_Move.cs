using UnityEngine;
using System.Collections;

public class Hunter_Move : MonoBehaviour
{
	public float moveSpeed = 500f;
	public float jumpSpeed = 500f;
	public float fallSpeed = 500f;
	
	
	void Update ()
	{
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Translate (-Vector3.right * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.up * jumpSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (Vector3.down * fallSpeed * Time.deltaTime);
	}
}

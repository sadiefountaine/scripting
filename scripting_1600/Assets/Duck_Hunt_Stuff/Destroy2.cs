using UnityEngine;
using System.Collections;

public class Destroy2 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, 4f);
	}

	void OnMouseDown()
	{
		Destroy (gameObject);
	}
}

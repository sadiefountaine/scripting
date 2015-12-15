using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKeyDown ("Fire1"))
		{
			Destroy(gameObject, 5f);
		}
	}
}

﻿using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKey (KeyCode.Space))
		{
			Destroy(gameObject, 2);
		}
	}
}

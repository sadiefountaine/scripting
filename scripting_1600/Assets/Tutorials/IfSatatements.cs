/*
using UnityEngine;
using System.Collections;

public class IfSatatements : MonoBehaviour
{
	public float Battery = 100f;
	public float NeedsPower = 20f;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			PowerTest ();
		Battery -= Time.deltaTime * 8;
	}

	void PowerTest ()
	{
		// Battery if it needs power.
		if (Battery < NeedsPower) 
		{
			print ("Battery low");
		}
		// Battery is fully charged.
		else 
		{
			print ("100% Power");
		}
	}
}
*/
using UnityEngine;
using System.Collections;

public class IfSatatements : MonoBehaviour
{
	public float CarSpeed = 102;
	public float TooSlow = 15;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();
		CarSpeed -= Time.deltaTime * 2;
	}

	void TemperatureTest ()
	{
		// Car speed less than too slow.
		if (CarSpeed < TooSlow) 
		{
			print ("You shouldn't be on the road at this speed.");
		}
		// Car speed if it isn't too slow.
		else 
		{
			print ("You're going to get pulled over");
		}
	}
}
using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{
	//For Loop
	/*
	int cake = 10;

	void Start ()
	{

		for(int i = 0; i < cake; i++)
		{
			Debug.Log("Cutting cake number:" + i);
		}
	}
	 */

	//While Loop
	int cakeInHand = 5;

	void Start()
	{
		while(cakeInHand > 0)
		{
			Debug.Log ("I'm going to eat the cake");
			cakeInHand--;
		}
	}
}

using UnityEngine;
using System.Collections;

public class Invoke_Bullet_Thing : MonoBehaviour
{
	public Rigidbody Rocket;
	public Transform barrelEnd;
	
	void Update()
	{
		if (Input.GetButtonDown ("Space"))
		{
			Rigidbody RocketInstance;
			RocketInstance = Instantiate (Rocket, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			Rocket.AddForce (barrelEnd.forward * 5000);
		}
	}
}
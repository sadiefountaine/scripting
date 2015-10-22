using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour
{
	//Inventory
	public class Stuff
	{
		public int rocks;
		public int shoes;
		public int arrows;
		public float fuel;

		public Stuff(int ro, int sho, int arw)
		{
			rocks = ro;
			shoes = sho;
			arrows = arw;
		}
		public Stuff(int ro, float fu)
		{
			rocks = ro;
			fuel = fu;
		}
		//Constructor
		public Stuff ()
		{
			rocks = 1;
			shoes = 1;
			arrows = 1;
		}
	}
	//Instance of Stuff Class
	public Stuff myStuff = new Stuff (17, 4, 9);

	public Stuff myOtherStuff = new Stuff (18, 4.25f);

	void Start ()
	{
		Debug.Log (myStuff.rocks);
	}
	
	//Movement Controls
	public float speed;
	public float turnSpeed;


	void Update()
	{
		Movement ();
	}

	void Movement ()
	{
		float forwardMovement = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float turnMovement = Input.GetAxis ("Horizontal") * turnSpeed * Time.deltaTime;

		transform.Translate (Vector3.forward * forwardMovement);
		transform.Rotate (Vector3.up * turnMovement);
	}
}
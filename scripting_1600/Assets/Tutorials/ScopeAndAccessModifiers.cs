/*
using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
	public int car = 3;
	//public stuff shows up and is editable in Unity (you don't have to open the script to edit it).

	private int bus = 0;
	private int truck = 2;
	//private stuff doesn't show up. It wouldn't show up anyway, but apparently this is a good practice.
	//these values are assigned, but never used again because that is what the example did... not sure why... so I decided to add it to the bottom two voids, which made my numbers larger than just the car = 4.
	private AnotherClass theOtherClass;

	void Start()
	{
		car = 4;

		//adding AnotherClass public integers into this Class.
		theOtherClass = new AnotherClass ();
		theOtherClass.Clothes (car, theOtherClass.socks);
		//pulling the integer socks that was in the public Clothes section into this Class.
	}

	void NewThings (int robot, int radio, int bus, int truck, int car)
	{
		int happiness;
		happiness = robot * radio * bus * truck * car;
		Debug.Log (happiness);
		//not quite sure what this is for other than it includes the public integer from before, and it is declaring new integers and using them to equal happiness.
		//happiness is the integer I decided to use. Basically robot times radio times car equals happiness.
	}

	void Update ()
	{
		Debug.Log ("Car is set to:" + car + bus + truck);
		//I tested this in Unity, and because I added car and bus and truck, the car is set to 402. It was originally just car, which made the car set to 4. This repeats infinitely in the script... and Im not sure why except that I never told it to stop so... I guess it doesn't.
	}
}
*/
using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour 
{

	int example = 15;
	// Use this for initialization
	//This is a comment. Leaving notes is good. The application won't try to run this.
	void Start () 
	{
		//example = MultiplyByFive (example);
		example = DivideByFive (example);
		Debug.Log (example);
	}
	
	// Update is called once per frame
	//void Update ()
	//int MultiplyByFive (int number)
	int DivideByFive (int number)
	{
		int ret;
		ret = number / 5;
		return ret;
	}
}
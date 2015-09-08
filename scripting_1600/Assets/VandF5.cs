using UnityEngine;
using System.Collections;

public class VandF5 : MonoBehaviour 
{
	int hopscotch = 25;
	// Use this for initialization
	void Start () 
	{
		hopscotch = DivideByFive (hopscotch);
		Debug.Log (hopscotch);
	}
	int DivideByFive (int number)
	{
		int ret;
		ret = number / 5;
		return ret;
	}

	// Update is called once per frame

	//void Update () 
	
}

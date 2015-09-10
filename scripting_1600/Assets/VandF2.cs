using UnityEngine;
using System.Collections;

public class VandF2 : MonoBehaviour 
{
	int box = 25;
	// Use this for initialization
	void Start () 
	{
		box = AddFive (box);
		Debug.Log (box);
	}
	
	// Update is called once per frame
	//void Update ()
	int AddFive (int number)
	{
		int ret;
		ret = number + 5;
		return ret;
	}
}

using UnityEngine;
using System.Collections;

public class VandF3 : MonoBehaviour 
{
	int star = 100;
	// Use this for initialization
	void Start () 
	{
		star = SubtractNine (star);
		Debug.Log (star);
	}
	
	// Update is called once per frame
	int SubtractNine (int number)
	//void Update () 
	{
		int ret;
		ret = number - 9;
		return ret;
	}
}

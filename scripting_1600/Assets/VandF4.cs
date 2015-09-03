using UnityEngine;
using System.Collections;

public class VandF4 : MonoBehaviour 
{
	int bug = 52;
	// Use this for initialization
	void Start () 
	{
		bug = AddEight (bug);
		Debug.Log (bug);
	}
	
	// Update is called once per frame
	int AddEight (int number)
	//void Update () 
	{
		int ret;
		ret = number + 8;
		return ret;
	}
}

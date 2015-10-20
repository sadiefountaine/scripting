using UnityEngine;
using System.Collections;

public class Duck_Arrays : MonoBehaviour
{
	public GameObject[] characters;
	
	void Start ()
	{
		characters = GameObject.FindGameObjectsWithTag ("Player");
		
		for (int i = 0; i < characters.Length; i++)
		{
			
			Debug.Log ("Duck number "+ i +" is named " + characters[i].name);
			
		}
	}
}

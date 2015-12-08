using UnityEngine;
using System.Collections;

public class Invoke : MonoBehaviour
{
	public GameObject Duck;


	void Start()
		{
			InvokeRepeating ("SpawnObject", 1, 5);
		}

	void SpawnObject()
		{
		float x = Random.Range (-151.0f, 10.0f);
		float z = Random.Range (-151.0f, 10.0f);
		Instantiate(Duck, new Vector3(x, -89, -300), Quaternion.identity);
		}
}
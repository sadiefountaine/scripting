using UnityEngine;
using System.Collections;

public class Invoke_Bullet_Thing : MonoBehaviour
{
	public GameObject Bullet;
	
	void Start()
	{
		InvokeRepeating ("SpawnObject", 1, 4);

	}
	
	void SpawnObject()
	{
		float x = Random.Range (-2.0f, 2.0f);
		float z = Random.Range (-2.0f, 2.0f);
		Instantiate(Bullet, new Vector3(-3, -193, -253), Quaternion.identity);
	}
}

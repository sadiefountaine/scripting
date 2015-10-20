using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour 
{
	enum Animals{Dog, Cat, Hamster, Chinchilla};

	void Start () 
	{
		//Animals myAnimals;

		//myAnimals = Animals.Cat;
	}
	

	Animals OppositeAnimals (Animals ani)
	{
		if (ani == Animals.Cat)
			ani = Animals.Dog;
		else if (ani == Animals.Dog)
			ani = Animals.Cat;
		else if (ani == Animals.Chinchilla)
			ani = Animals.Hamster;
		else if (ani == Animals.Hamster)
			ani = Animals.Chinchilla;


		return ani;
	}
}

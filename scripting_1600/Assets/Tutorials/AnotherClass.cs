using UnityEngine;
using System.Collections;

public class AnotherClass

{
	public int shirt;
	public int socks;

	private int pencil;
	private int pen;

	public void Clothes (int a, int b)
		//naming the public section of ints Clothes. There are two public ints, thus a and b.
	{
		int solution;
		solution = a + b;
		Debug.Log ("Clothes:" + solution);
		//This is saying that shirts and socks added together make up the Clothes section.
	}

	private void WritingUtensils (int a, int b)
		//naming the private section of ints WritingUtensils. Again, there are two ints, thus a and b.
	{
		int solution;
		solution = a + b;
		Debug.Log ("WritingUtensils:" + solution);
		//Pencil and pen added up make up the WritingUtensils section.
	}
	
}
//for some reason Unity is not recognizing this Class. ScopeAndAccessModifiers still works, but this wont.

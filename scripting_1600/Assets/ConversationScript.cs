using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour 
{
	public int greeting = 3;
	
	void Greet()
	{
		switch (greeting)
		{
		case 3:
			print ("It's nice to meet you!");
			break;
		case 2:
			print ("I don't want to talk to you.");
			break;
		case 1:
			print ("... Why are you talking to me?");
			break;
		default:
			print ("Incorrect greeting.");
			break;
		}
	}

}

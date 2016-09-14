using UnityEngine;
using System.Collections;


public class ConsoleAdventure_part_1 : MonoBehaviour 
{


	// Use this for initialization
	void Start () 
	{

		BeginGame ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.G)) 
		{
			Debug.Log ("Mr V says, have a seat...followed up by a 70 min lecture about responsible, respect,  & responsibility. Game over");
			Debug.Log ("thank you for playing. Hit Y to play again");

		}
		
		else if (Input.GetKeyDown (KeyCode.A)) 
		{
			Debug.Log ("Mr. V writes you a pass and you leave for the hallway");
			Debug.Log ("In the hallway you see a giant rollerball heading straight for you");
			Debug.Log ("Hit J to jump or D to duck");

			
		}
		else if (Input.GetKeyDown (KeyCode.J)) 
		{
			Debug.Log ("You jump and do three backflips to safety. You Win");
			Debug.Log ("thank you for playing. Hit Y to play again");

			
		}
		
		else if (Input.GetKeyDown (KeyCode.D)) 
		{
			Debug.Log ("You get smushed and it doesn't feel that great as you limp away. Game Over");
			Debug.Log ("thank you for playing. Hit Y to play again");

			
		}
		
		else if (Input.GetKeyDown (KeyCode.Y)) 
		{
			BeginGame();
		}
	}
	
	// use this to begin a new game
	void BeginGame()
		
	{
		

		Debug.Log ("Welcome to choose your own adventure.");
		Debug.Log ("You are stuck in Mr. V's classroom and really need to go to your locker.");
		Debug.Log (" Hit G for get up and walk towards the door. Hit A for ask for a pass");

		
		
		
	}
	
	
}

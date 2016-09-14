using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AdventureControl_part_3 : MonoBehaviour 
{
	public Text myAdventureText;
	bool classroomActive;
	bool hallActive;
	bool gameOverActive;

	// Use this for initialization
	void Start () 
	{
		
		BeginGame ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKeyDown (KeyCode.G) && classroomActive == true) 
		{
		myAdventureText.text = "Mr V says, have a seat...followed up by a 70 min lecture about responsible, respect,  & responsibility. Game over \n\n\n thank you for playing. Hit Y to play again";
		gameOverActive = true;
		}
	
	else if (Input.GetKeyDown (KeyCode.A) && classroomActive == true) 
		{
		
			myAdventureText.text = "Mr. V writes you a pass and you leave for the hallway. In the hallway you see a giant rollerball heading straight for you!! \n\n\n Hit J to jump or D to duck";
			classroomActive = false;
			hallActive = true;

		}
	else if (Input.GetKeyDown (KeyCode.J) && hallActive == true) 
		{

			myAdventureText.text = "You jump and perform three backflips to safety. You Win!!! \n\n\n thank you for playing. Hit Y to play again";
			hallActive = false;
			gameOverActive = true;

		}

	else if (Input.GetKeyDown (KeyCode.D) && hallActive == true) 
		{
	
			myAdventureText.text = "You get smushed and it doesn't feel that great as you limp away. Game Over!!!!\n\n\n thank you for playing. Hit Y to play again ";
			hallActive = false;
			gameOverActive = true;


		}

	else if (Input.GetKeyDown (KeyCode.Y) && gameOverActive == true) 
		{
			BeginGame();
		}
	}

	// use this to begin a new game
	void BeginGame()

	{
		
		myAdventureText.text = "Welcome to choose your own adventure. You are stuck in Mr. V's classroom and really need to go to your locker. \n\n\n Hit G to get up and walk towards the door. Hit A for ask for a pass";
		classroomActive = true;
		hallActive = false;
		gameOverActive = false;
		

	}


}

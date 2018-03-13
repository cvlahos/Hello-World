using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public int totalGemCount; // variable will store how many Gems in the level as a whole number
	public Text winText;			//Store a reference to the UI Text component which will display the 'You win' message

	

	public bool haveKey; //variable will store true - or false - in this case...if the player has the key or not


	void Start () 
	{
		//Initialze winText to a blank string since we haven't won yet at beginning.


		winText.text = "";


		haveKey = false; // at the start of the level the player shouldn't have the key
	}
	
	// Update is called once per frame
	void Update () 
	{

		//Debug.Log ("total gem count is - " + totalGemCount);
		Debug.Log ("player has the key = " + haveKey);



		WinChecker ();
	
	}


	//This function updates the text displaying the victory message.

	void WinChecker()
	{
		if (haveKey == true && totalGemCount > 0) 
		{
			winText.text = "Make sure you collect all the gems";
		}
		
		
		if (totalGemCount == 0 && haveKey == false) 
		{
			winText.text = "Make sure you also get the key";
		}
		
		
		if (totalGemCount == 0 && haveKey == true) 
		{
			winText.text = "You Win!";
		}

	}

}





































/*

if (haveKey == true && totalGemCount > 0) 
{
winText.text = "Make sure you collect all the gems";
}


if (totalGemCount == 0 && haveKey == false) 
{
	winText.text = "Make sure you also get the key";
}


if (totalGemCount == 0 && haveKey == true) 
{
	winText.text = "You Win!";
}
*/
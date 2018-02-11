using UnityEngine;
using System.Collections;

public class PointManager : MonoBehaviour 
{
	public GameplayController gameplayController;

	void Start()
	{
		gameplayController.totalDots += gameplayController.totalDots +1; // when the level starts every dot (point) that is in the level is added up and stored in a variable called totalDots.

	}


	void Update()
	{


	}

	void OnTriggerEnter2D(Collider2D target) 
	{
		if (target.tag == "PacMan") // if the collision that happens is with the game object that is tagged PacMan
			{
				// the below three lines of code inside the if statement are what happens when pac man gobbles up a point
				gameplayController.score = gameplayController.score + 20; //add twenty points to the score
				gameplayController.totalDots = gameplayController.totalDots - 1; // subtract a point from the total dot(point variable)
				Destroy(gameObject); // destroy the point sprite
			}
	} 
}

//End

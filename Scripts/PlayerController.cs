using UnityEngine;
using System.Collections;



public class PlayerController : MonoBehaviour 
{

	public float speed;				//Floating point variable to store the player's movement speed.

	//Store a reference to the Gamemanager 

	//public Rigidbody2D playerRb;		//Store a reference to the Rigidbody2D component required to use 2D Physics.



	// Use this for initialization
	void Start()
	{

	}

	void Update()
	{

		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.Translate (-speed,0,0);


		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Translate (speed, 0, 0);

		}
		
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.Translate (0, speed, 0);
			
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			
			transform.Translate (0, -speed, 0);

		}


	}
	

}



	






















/*
if (Input.GetKey (KeyCode.LeftArrow)) 
{
	transform.Translate (-speed, 0, 0);
	
	//playerRb.AddTorque (-speed);
	//playerRb.AddForce(new Vector2(-speed,0f));
}
if (Input.GetKey (KeyCode.RightArrow)) 
{
	transform.Translate (speed, 0, 0);
	
	//playerRb.AddTorque (speed);
	//playerRb.AddForce(new Vector2(speed,0f));
}

if (Input.GetKey (KeyCode.UpArrow)) 
{
	transform.Translate (0, speed, 0);

	//playerRb.AddForce(new Vector2(0f,speed));
	
}

if (Input.GetKey (KeyCode.DownArrow)) 
{

	transform.Translate (0, -speed, 0);
	
	//playerRb.AddForce(new Vector2(0f,-speed));
}

*/
	
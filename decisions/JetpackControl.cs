using UnityEngine;
using System.Collections;

public class JetpackControl : MonoBehaviour 
{
	public Rigidbody sphereRB;

	public int thrusterForce;



	// Use this for initialization
	void Start () 
	{
		int fuel;
		fuel = 500;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (fuel);
		//if the player holds the spacebar then the script will check if the jetpack has fuel
		if (Input.GetKey(KeyCode.Space)) 
		{
			//if the fuel variable is greater than 0 (an empty tank) then the codeblock below will run
			if (fuel > 0) 
			{
				// the below code will take control over the sphere's rigidbody and add a local force relative to the Y axis. The variable thrusterForce controlls how much force
				sphereRB.AddRelativeForce (0,thrusterForce,0);
				// while the force is applied fuel will be going down
				fuel = fuel - 1;
			}
		}

	}
}

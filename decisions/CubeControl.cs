using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour 
{
	public Rigidbody cubeRB;

	public int thrusterForce;

	int fuel;

	// Use this for initialization
	void Start () 
	{
		fuel = 300;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (fuel);

		if (fuel >= 0) 
		{
			cubeRB.AddForce (0,thrusterForce,0);
			fuel = fuel - 1;
		}


	}
}

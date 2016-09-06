using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour 
{
	int x;
	int y;
	int z;
	int teamAverage;
	
	// Use this for initialization
	void Start () 
	{
		
		x = 50;
		y = 100;
		z = (x + y) / 2;

		Debug.Log (z);
		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}

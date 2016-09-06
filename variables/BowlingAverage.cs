using UnityEngine;
using System.Collections;

public class BowlingAverage : MonoBehaviour 
{
	int janeScore;
	int bobScore;
	int mikeScore;
	int teamAverage;

	// Use this for initialization
	void Start () 
	{
	
		janeScore = 147;
		bobScore = 116;
		mikeScore = 196;
		teamAverage = (janeScore + bobScore + mikeScore) / 3;

	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (teamAverage);
	}
}

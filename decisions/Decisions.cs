using UnityEngine;
using System.Collections;

public class Decisions : MonoBehaviour 
{

	public float disco;
	// Use this for initialization
	void Start () 
	{
		disco = 2.5f;

	}
	
	// Update is called once per frame
	void Update () 
	{
	if (disco > 8.3f) 
		{
			Debug.Log ("Mr. V is the man!!");
		}

		else 
		{

			Debug.Log ("Disco is dead");
		}

		}

}

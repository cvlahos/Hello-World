using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	public float rotateSpeed;

	//Update is called every frame
	void Update () 
	{

		transform.Rotate (0, 0, rotateSpeed);


	}
}

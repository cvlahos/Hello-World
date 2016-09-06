using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour 
{
	public Rigidbody cubeRB;

	public int jumpForce;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		cubeRB.AddForce (0,jumpForce,0);
	}
}

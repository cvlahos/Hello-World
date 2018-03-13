using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour 
{
	public GameManager gameManager;//Store a reference to the GameManager Class so we can change if the player has a key or not

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	//OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
	void OnTriggerEnter2D() 
	{
		//Debug.Log ("trigger collder activated");
		gameManager.haveKey = true;
		Destroy (gameObject); // this will destroy the game object this script is on - removing the key in this case
	}
	

}

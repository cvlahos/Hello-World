using UnityEngine;
using System.Collections;

public class Gem : MonoBehaviour 
{
	public GameManager gameManager;//Store a reference to the GameManager Class so we can use the public variable that stores total gems
	

	// Use this for initialization
	void Start () 
	{
		//gameManager.totalGemCount = gameManager.totalGemCount + 1;

		gameManager.totalGemCount = gameManager.totalGemCount + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	//OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
	void OnTriggerEnter2D() 
	{
		//Debug.Log ("trigger collder activated");
		gameManager.totalGemCount = gameManager.totalGemCount - 1;
		Destroy (gameObject);
	}


}

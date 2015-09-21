using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{

	int numRockets = 5;
	// Use this for initialization
	void Start () 
	{
	while (numRockets > 0) 
		{
			Debug.Log ("Rocket Launched!");
			numRockets--;
		}
	}

}

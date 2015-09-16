using UnityEngine;
using System.Collections;

public class IfStatement : MonoBehaviour {

	int coin = 25;
	// Use this for initialization
	void Start ()
	{

		if (coin >= 0 && coin <= 10) {
			Debug.Log ("You bought a Standard Seat");

		} 
		else if (coin >= 10 && coin <= 20) 
		{
			Debug.Log ("You bought a Deluxe Seat");
		} 

		else 
		{
			Debug.Log ("Payment not accepted, buy a Standard or Deluxe Seat");
		}
	
	}
	

}

using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	//Declaration of an Array
	int[]myArray= new int[7];

	//Declaring and Initializing an Array
	int[] anotherArray = {1,2,3,4};

	//Access Int Array from the Inspector
	public GameObject [] players;

	void Start () 
	{
		//Accessing the elements of IntArray
		myArray [0] = 34;
		myArray [1] = 4;

		for (int i=0; i < anotherArray.Length; i++) 
		{
			Debug.Log ("number in the array" + anotherArray [i]);
		}
			
		
	}
	

}

using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		int[] intArray = new int[4];

		intArray [0] = 9;
		intArray [1] = 21;
		intArray [2] = 20;
		intArray [3] = 15;

		foreach (int numDate in intArray) 
		{
			print (numDate);
		}
	}	

}

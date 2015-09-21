using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	int numMinions = 5;
	// Use this for initialization
	void Start () 
	{
		for (int i=0; i < numMinions; i++) 
		{
			Debug.Log("Number of Minions created: " + i);
		}
	}
}

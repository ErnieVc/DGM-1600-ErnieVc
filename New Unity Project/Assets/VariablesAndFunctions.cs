﻿using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {

	int myInt = 5;

	// Use this for initialization
	void Start () {
		myInt = MultiplyByFive (myInt);
		Debug.Log (myInt);
	}


	int MultiplyByFive(int intNumber){
		int result;
		result = intNumber * 5;
		return result;
	}



	// Update is called once per frame
	//void Update () {
	
	//}
}

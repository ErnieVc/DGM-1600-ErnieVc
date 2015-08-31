using UnityEngine;
using System.Collections;

public class VarFunc : MonoBehaviour {

	int myInt = 5;
	// Use this for initialization
	void Start () {
		myInt = MultTwo(myInt);
		Debug.Log (myInt);
	}

	int MultTwo( int number){
		int result;
		result = number * 2;
		return result;
	}
	// Update is called once per frame
	//void Update () {
	
	//}
}

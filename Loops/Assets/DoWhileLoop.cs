using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int num = 2;
		do {
			print ("Automatic Message " + num);
			num--;
		} while(num > 0);
	
	}
}

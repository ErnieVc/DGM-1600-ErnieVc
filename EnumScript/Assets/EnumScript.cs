using UnityEngine;
using System.Collections;

public class EnumScript : MonoBehaviour {

//declaring an enum:
//enum Direction {North,East, South,West};

//Assigning values to the constants
//	enum Direction {North=1,East=2, South=34,West=9};

//changing type of an enum
	enum Direction:short {North,East, South,West};

	// Use this for initialization
	void Start () {
	
	//Creating a enum variable 
	Direction myDirection;
	
	myDirection=Direction.South;
	
	EnumFunction(myDirection);
	}
	
	Direction EnumFunction(Direction adr)
	{
	if (adr == Direction.South)
	Debug.Log("Your number is"+adr);
	return adr;
	}
	
}

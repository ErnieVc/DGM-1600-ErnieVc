using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	int onev = 10;
	float secondv;

	public class Stuff
	{
		public int thing;
	public Stuff()
		{

		}

	public Stuff(int firstV, float twoV)
	{
			firstV = 100;
			secondv=twoV;
	}

	}

	public Stuff my2ndStuff = new Stuff (onev, 2.5);

	void Start()
	{
		Stuff my3rdStuff = my2ndStuff;
		my3rdStuff.thing = 100;
		//Debug.Log(myStuff.bullets); 
	}
}
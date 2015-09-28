using UnityEngine;
using System.Collections;

public class AnotherClass
{
	public int ten= 10;

	
	public void Add (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Fruit total: " + answer);
	}
	
	
	private void Multiply (int a, int b)
	{
		int answer;
		answer = a * b;
		Debug.Log("Office Supplies total: " + answer);
	}
}
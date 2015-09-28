using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
	public int alpha;
	
	
	private int beta = 0;
	private int gamma = 5;
	
	
	private AnotherClass myOtherClass;
	
	
	void Start ()
	{
		alpha = 29;
		
		myOtherClass = new AnotherClass();
		myOtherClass.Add(alpha, myOtherClass.ten);
	}
}
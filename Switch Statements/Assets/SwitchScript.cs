using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour 
{
public int level=5;

void Start(){

		LevelReading();
}

void LevelReading()
{
switch (level)
{
case 1: 
print("One");
break;

case 5: 
print("Five");
break;

default://else
print("Default Level");
break;
}

}


}

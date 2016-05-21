using UnityEngine;
using System.Collections;     /* This is the outer most level of the program framework. and is use to make namespace available for the program or app to use
this namespace is using the system for collections along with unity */

public class Vars : MonoBehaviour 
{ // This is used in grouping or organizing differant functions and variables together for methods to become a block of data or info

	// Use this for initialization
	void Start () 
	{

		int x = 2016;

		string message = "Understood";
		string upperMessage = message.ToUpper ();
		Console.WriteLine (upperMessage);
	
		float pop = 3.5f;
	
	}
}

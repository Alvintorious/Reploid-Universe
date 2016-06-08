using UnityEngine;
using System.Collections;

public class IfStatments : MonoBehaviour {

	public bool myBool = true;
	public int myint = 1;
	public string mystring;
	const string myconst = "OU812";
	// Update is called once per frame
	void Update () {
		if (myint >= 1)
			print ("That's correct, you have unlocked health powerUps");
		else
			print (false);
	}
}

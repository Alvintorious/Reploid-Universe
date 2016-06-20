using UnityEngine;
using System.Collections;

public class scope2 : MonoBehaviour {


	private scope2  MyFruit;

	void Start () {
		MyFruit = new scope2 ();
		MyFruit.AddApples (10);
		MyFruit.AddApples (10);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class scope2 : MonoBehaviour {


	private Scope  MyFruit;

	void Start () {
		MyFruit = new Scope ();
		MyFruit.AddApples (10);
		MyFruit.AddApples (10);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

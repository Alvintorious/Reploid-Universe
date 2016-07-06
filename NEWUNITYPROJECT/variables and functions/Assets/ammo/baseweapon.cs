using UnityEngine;
using System.Collections;

public class baseweapon : MonoBehaviour {

	public baseammo thisAmmo;

	
	// Update is called once per frame
	void Update () {
		thisAmmo.fire ();
	}
}

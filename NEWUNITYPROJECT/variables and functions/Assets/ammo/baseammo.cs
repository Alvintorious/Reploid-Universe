using UnityEngine;
using System.Collections;
[System.Serializable]
public class baseammo {

	public int ammoCount;
	public int ammoPower;


	public void fire () {
		if (ammoCount > 0) {
		ammoCount--;
			Debug.Log (ammoCount);
		}  else {
			Debug.Log ("Out of Ammo");

		}
	}
}
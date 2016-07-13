using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class WeaponsInventory : MonoBehaviour {

	public List<WeaponBase> myWeapons = new List<WeaponBase> ();

	void Update () {
		if (Input.GetKeyUp (KeyCode.R) && myWeapons.Count > 0)
			myWeapons [0].gameObject.SetActive (true);
		myWeapons.RemoveAt (0);
	}

}

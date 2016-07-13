using UnityEngine;
using System.Collections;

public class WeaponBase : MonoBehaviour {


	public WeaponsInventory myWeaponsInventory;

	// Weapon Name is the game object Name
	public int firePower;
	public int ammoCount;

	void OnMouseUp () {
		myWeaponsInventory.myWeapons.Add (this);
		gameObject.SetActive (false);

	}
}

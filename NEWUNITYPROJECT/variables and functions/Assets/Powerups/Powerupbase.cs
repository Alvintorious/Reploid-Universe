using UnityEngine;
using System.Collections;

public class Powerupbase : MonoBehaviour {

	public int Power = 100;
	public int speed = 10;
	public int health = 5;

	public PowerUpInventory myInventory;


	void OnMouseUp () {
		myInventory.AddPowerUpToList (this);
		gameObject.SetActive (false);
	}
		
}

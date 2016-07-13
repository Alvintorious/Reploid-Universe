using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PowerUpInventory : MonoBehaviour {

	private int i = -1;

	public List<Powerupbase> MyPowerUps = new List<Powerupbase> ();

	public void AddPowerUpToList (Powerupbase _pub) {
		MyPowerUps.Add (_pub);
		i++;
		print (_pub.name);
	}
   
	void Update () {
			if (Input.GetKeyDown (KeyCode.A)) {
				if(i>-1 && i < 10) {
				PowerupStatics.mySpeed += MyPowerUps [i].speed;
				MyPowerUps.RemoveAt (i);
				i--;
				print (PowerupStatics.mySpeed);
			}
		}
	}
}
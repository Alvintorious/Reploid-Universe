using UnityEngine;
using System.Collections;

public class Multiplayer : MonoBehaviour {


	public PlayerHealth[] players;

	void Start(){
		foreach (PlayerHealth _hd in players) {
			print (_hd.username + " " + _hd.strength);

		}
	}
}

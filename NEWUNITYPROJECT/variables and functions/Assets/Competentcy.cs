using UnityEngine;
using System.Collections;

public class Competentcy : MonoBehaviour {


	public string Stupid;
	public string Retard;

	public bool Win = true;
		
	
	

	void TestWinner () {
	
		if (Win) {

			print (Stupid + "Winner");
		} else {

			print (Retard + "Winner");
		}
	}
}
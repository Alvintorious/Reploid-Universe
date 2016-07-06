using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {


	public string[] myFamily;
	string familyArray;

	void Start () {
		foreach (string _familyName in myFamily) {
			familyArray += (" " + _familyName + " Loves ");
			print (familyArray);
		}
	}
}

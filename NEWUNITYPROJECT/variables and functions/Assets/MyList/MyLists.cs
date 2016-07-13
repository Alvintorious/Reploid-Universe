using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class MyLists : MonoBehaviour {

	public List<string> playerNames = new List<string> ();
	public Text myInputText;

	

	void OnMouseUp () {
        playerNames.Add (myInputText.text);
	}
}

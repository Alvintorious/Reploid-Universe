using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour 
{
	int numEnemies = 3;



	void start ()
	{
		for (int i = 0; i < numEnemies; i++) {
			Debug.Log ("Creat enemy number: " + i);
		}
	}
}

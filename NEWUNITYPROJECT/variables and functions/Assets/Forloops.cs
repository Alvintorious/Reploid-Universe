using UnityEngine;
using System.Collections;

public class Forloops : MonoBehaviour 
{


	public int[] playerScores;


	void Start () 
	{
		for (int i = 0; i < playerScores.Length; i+=10) 
		{
			playerScores [i] += 10;
			playerScores [i] += 10;
			print (playerScores [i]);
			print (i);
		}
	}
}


using UnityEngine;
using System.Collections;

public class WhileLoops : MonoBehaviour 
{
	int cupsInSink = 5;



	void Start () 
	{
		while(cupsInSink > 0)
		{
			Debug.Log ("I've washed a cup!");
			cupsInSink--;
		}
	}
}

using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {


	public NavMeshAgent agent;


	void Start () {
		agent = GetComponents<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = Player.position;
	}
}

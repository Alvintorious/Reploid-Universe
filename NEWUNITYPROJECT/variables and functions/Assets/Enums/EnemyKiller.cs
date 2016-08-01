using UnityEngine;
using System.Collections;

public class EnemyKiller : MonoBehaviour {


	void OnMouseUp () {
		MyEnums.gameState = MyEnums.gameStates.Attacked;
	}

}

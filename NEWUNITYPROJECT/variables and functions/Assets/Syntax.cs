using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour 
{


	int stand (int _l, int _r){
		return _l + _r;
	}

	int walk (int _l, int _r){
		int _w = (_l + _r + 1);
		return _w;
	}

	int run (int _l, int _r){
		int _R = (_l + _r + 2);
			return _R;
	}

	void Start(){
		print (stand (0, 0));
		print (walk (0, 0));
		print (run (0, 0));
	}

}
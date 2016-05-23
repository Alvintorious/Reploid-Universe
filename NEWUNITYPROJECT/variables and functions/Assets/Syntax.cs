using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour 
{

	int doBeDo = 45;

	int DoBeDo (int _d, int _p) {
		return _d + _p;
	}

	int Blablaby2(int _d, int _p) {
		int _g = (_d + 10) * 2;
		return _g;
	}
	void Start () {
		print (doBeDo);
		doBeDo = DoBeDo (45, 27);
		print (doBeDo);
		doBeDo = 12;
		print (doBeDo);



	}

}
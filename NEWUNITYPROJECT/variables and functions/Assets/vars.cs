using UnityEngine;
using System.Collections;

public class vars : MonoBehaviour {

    int git = 45
		;

    void Start()
    {
        git = ByTwo(git);
        Debug.Log(git);
    }

    int ByTwo(int number)
    {
        int got;

        got = number * 2;

        return got;


    }
}

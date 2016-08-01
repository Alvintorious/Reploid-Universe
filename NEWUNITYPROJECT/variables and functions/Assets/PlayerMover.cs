using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {

	public CharacterController controller;
	public Vector3 controllerPosition;
	// public Vector3 controllerRotation
	//public float rotateAngle = 5;
	public float speed = 5;
	public float jump = 35;

	void Start () {
		controller = GetComponents<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)) {
			controllerPosition.y += jump;
			//	Or for 3D controllerrotation.y = rotateAngle*Input.Getaxis("Horizantal");
			// transform.Rotate (controllerRotation);

		controllerPosition = transform.TranformDirection (controllerPosition);
		controllerPosition.x = speed*Input.GetAxis("Vertical");
		controllerPosition.y = -speed;
		
		controller.Move (controllerPosition * Time.deltaTime);
	}
}

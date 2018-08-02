using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehavior : MonoBehaviour {

	public Transform player;
	public float smooth = 0.1f;
	public float zPosition = 1;
	public float yPosition = 15;
	public float cameraAngle = 70;
	int angle = 0;
	int anglePos = 0;

	private Vector3 velocity = Vector3.zero;
	private Vector3 position = new Vector3 ();

	// Use this for initialization
	void Start () {
		transform.eulerAngles = new Vector3 (cameraAngle, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag ("Player") != null) {
			switch (anglePos) {
			case 0:
				camPosition0 ();
				break;

			case 1:
				camPosition1 ();
				break;

			case 2:
				camPosition2 ();
				break;

			case 3:
				camPosition3 ();
				break;

			}
		}

		if(Input.GetKeyUp("v")){
			changeAngle ();
		}

	}

	//Methods
	void changeAngle (){
		angle += 1;
		if (angle > 3) {
			angle = 0;
		}

		anglePos += 1;
		if (anglePos > 3) {
			anglePos = 0;
		}

		switch (angle) {
		case 0:
			transform.eulerAngles = new Vector3 (cameraAngle, 0, 0);
			break;

		case 1:
			transform.eulerAngles = new Vector3 (cameraAngle, 90, 0);
			break;

		case 2:
			transform.eulerAngles = new Vector3 (cameraAngle, 180, 0);
			break;

		case 3:
			transform.eulerAngles = new Vector3 (cameraAngle, 270, 0);
			break;

		}
			
	}

	void camPosition0 (){
		position.x = player.position.x;
		position.z = player.position.z - zPosition;
		position.y = player.position.y + yPosition;
		transform.position = Vector3.SmoothDamp (transform.position, position, ref velocity, smooth);
	}

	void camPosition1 (){
		position.x = player.position.x - zPosition;
		position.z = player.position.z;
		position.y = player.position.y + yPosition;
		transform.position = Vector3.SmoothDamp (transform.position, position, ref velocity, smooth);
	}

	void camPosition2 (){
		position.x = player.position.x;
		position.z = player.position.z + zPosition;
		position.y = player.position.y + yPosition;
		transform.position = Vector3.SmoothDamp (transform.position, position, ref velocity, smooth);
	}
		
	void camPosition3 (){
		position.x = player.position.x + zPosition;
		position.z = player.position.z;
		position.y = player.position.y + yPosition;
		transform.position = Vector3.SmoothDamp (transform.position, position, ref velocity, smooth);
	}

}

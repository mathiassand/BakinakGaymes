using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//See following link for possible implementation of stats and such.
//https://forum.unity.com/threads/tutorial-character-stats-aka-attributes-system.504095/

public class player : MonoBehaviour {
	public GameObject playerObject;
	public Transform cameraAngle;
	public float movementSpeed;
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerRotation ();
		playerMovement ();
	}

	//Methods
	void playerRotation(){
		Plane playerPlane = new Plane (Vector3.up, transform.position);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		float hitDistance = 0.0f;

		if (playerPlane.Raycast (ray, out hitDistance)) {
			Vector3 targetPoint = ray.GetPoint (hitDistance);
			Quaternion targetRotation = Quaternion.LookRotation (targetPoint - transform.position);
			targetRotation.x = 0;
			targetRotation.z = 0;
			playerObject.transform.rotation = Quaternion.Slerp (playerObject.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
		}
	}

	void playerMovement(){
		Vector3 camF = cameraAngle.forward;
		Vector3 camR = cameraAngle.right;
		camF.y = 0;
		camR.y = 0;
		camF = camF.normalized;
		camR = camR.normalized;
		//transform.position += new Vector3 (input.x, 0, input.y) * Time.deltaTime * 5;
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * movementSpeed;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * movementSpeed;

		transform.position += (camF*z + camR*x);
	}

}
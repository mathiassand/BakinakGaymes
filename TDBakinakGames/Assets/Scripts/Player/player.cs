using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public GameObject playerObject;

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
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * movementSpeed;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * movementSpeed;

		transform.Translate (x, 0, z);
	}

}
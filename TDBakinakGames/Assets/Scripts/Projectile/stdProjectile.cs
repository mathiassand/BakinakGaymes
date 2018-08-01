using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stdProjectile : ProjectileClass {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		projectileMovement ();
	}

	void OnTriggerEnter(Collider other){
		hitDetection (other);
	}
}

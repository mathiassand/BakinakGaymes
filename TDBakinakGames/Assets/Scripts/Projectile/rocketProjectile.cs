using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketProjectile : ExplosiveProjectileClass {

	
	// Update is called once per frame
	void Update () {
		projectileMovement ();
	}

	void OnTriggerEnter(Collider other){
		hitDetection (other);
	}
}

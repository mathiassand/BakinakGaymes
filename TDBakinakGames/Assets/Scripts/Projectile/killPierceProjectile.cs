using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPierceProjectile : ProjectileClass {

	
	// Update is called once per frame
	void Update () {
		projectileMovement ();
	}

	void OnTriggerEnter(Collider other){
		hitDetection (other);
	}

	public override void damageEnemy(Collider other){
		if (other.tag == "Enemy") {
			GameObject triggeringEnemy;
			triggeringEnemy = other.gameObject;
			triggeringEnemy.GetComponent<EnemyClass> ().health -= damage;
			if (triggeringEnemy.GetComponent<EnemyClass> ().health > 0) {
				Destroy (this.gameObject);
			}
		}
	}
}

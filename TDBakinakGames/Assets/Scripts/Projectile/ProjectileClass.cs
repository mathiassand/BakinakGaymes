using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileClass : MonoBehaviour {
	//The following variables should get their value from the RangedWeaponClass, that is the weapon
	//that fires the projectile.
	float travelledDistance;
	public float range;
	public float speed;
	public float damage;
	GameObject triggeringEnemy;

	//Functions:

	public void projectileMovement(){
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		projectileTravelCounter ();
	}

	public void projectileTravelCounter(){
		travelledDistance += 1 *  Time.deltaTime;
		if (travelledDistance >= range) {
			expire ();
		}

	}

	//Methods
	public void damageEnemy(Collider other){
		if (other.tag == "Enemy") {
			triggeringEnemy = other.gameObject;
			triggeringEnemy.GetComponent<EnemyClass> ().health -= damage;
			if (triggeringEnemy.GetComponent<EnemyClass> ().health > 0) {
				Destroy (this.gameObject);
			}
		}
		if (other.tag == "Wall") {
			Destroy (this.gameObject);
		}
	}

	public virtual void expire(){
		Destroy (this.gameObject);
	}
}

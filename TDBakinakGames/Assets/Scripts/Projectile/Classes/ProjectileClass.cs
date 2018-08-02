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

	//Functions:

	public virtual void projectileMovement(){
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		projectileTravelCounter ();
	}

	public virtual void projectileTravelCounter(){
		travelledDistance += 1 *  Time.deltaTime;
		if (travelledDistance >= range) {
			expire ();
		}

	}

	//Methods
	public virtual void damageEnemy(Collider other){
		if (other.tag == "Enemy") {
			GameObject triggeringEnemy;
			triggeringEnemy = other.gameObject;
			triggeringEnemy.GetComponent<EnemyClass> ().health -= damage;
			Destroy (this.gameObject);
		}
	}

	public virtual void hitWall(Collider other){
		if (other.tag == "Wall") {
			Destroy (this.gameObject);
		}
	}

	public virtual void hitDetection(Collider other){
		damageEnemy (other);
		hitWall (other);
	}

	public virtual void expire(){
		Destroy (this.gameObject);
	}
}
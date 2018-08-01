using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveProjectileClass : ProjectileClass {

	//Variables
	public float blastRadius;
	public Vector3 center;

	//Functions
	public virtual void Explosion(Vector3 center, float blastRadius){
		Collider[] hitColliders = Physics.OverlapSphere (center, blastRadius);
		int i = 0;
		while (i < hitColliders.Length) {
			if (hitColliders [i].tag == "Enemy") {
				hitColliders [i].GetComponent<EnemyClass> ().health -= damage;
			}
			i++;
		}
		Destroy (this.gameObject);
	}

	public override void damageEnemy(Collider other){
		if (other.tag == "Enemy") {
			centerUpdate ();
			Explosion (center, blastRadius);
		}
	}

	public override void hitWall(Collider other){
		if (other.tag == "Wall") {
			centerUpdate ();
			Explosion (center, blastRadius);
		}
	}

	void centerUpdate(){
		center = transform.position;
	}
}
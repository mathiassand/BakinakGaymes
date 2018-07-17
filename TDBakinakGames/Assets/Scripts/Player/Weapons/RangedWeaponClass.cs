using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class should contain basic funtions to spawn bullets and have them go in the
//direction the player aims.

public class RangedWeaponClass : WeaponClass {

	public float range;
	public float projectileSpeed;

	public GameObject bulletSpawnPoint;
	public GameObject bullet;
	private Transform bulletSpawned;

	void instantiateBullet(float angle){
		bulletSpawned = Instantiate (bullet.transform, bulletSpawnPoint.transform.position, Quaternion.identity);
		bulletSpawned.Rotate (0, bulletSpawnPoint.transform.rotation.eulerAngles.y+angle, 0);
		bullet.GetComponent<ProjectileClass> ().range = range;
		bullet.GetComponent<ProjectileClass> ().damage = damage;
		bullet.GetComponent<ProjectileClass> ().speed = projectileSpeed;

	}

	public override void attack(){
		instantiateBullet (0);
	}

}

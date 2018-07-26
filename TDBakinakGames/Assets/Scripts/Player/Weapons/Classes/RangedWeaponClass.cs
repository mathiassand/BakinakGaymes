using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class should contain basic funtions to spawn bullets and have them go in the
//direction the player aims.

public class RangedWeaponClass : WeaponClass {

	public GameObject bulletSpawnPoint;
	public GameObject bullet1;
	public GameObject bullet2;

	public float damage1;
	public float damage2;

	public float range1;
	public float range2;

	public float projectileSpeed1;
	public float projectileSpeed2;

	private Transform bulletSpawned;

	public virtual void instantiateBullet(GameObject projectile, float angle, float damage, float range, float projectileSpeed){
		projectile.GetComponent<ProjectileClass> ().range = range;
		projectile.GetComponent<ProjectileClass> ().damage = damage;
		projectile.GetComponent<ProjectileClass> ().speed = projectileSpeed;
		bulletSpawned = Instantiate (projectile.transform, bulletSpawnPoint.transform.position, Quaternion.identity);
		bulletSpawned.Rotate (0, bulletSpawnPoint.transform.rotation.eulerAngles.y+angle, 0);

	}

	public override void attack1(){
		instantiateBullet (bullet1, 0, damage1, range1, projectileSpeed1);
	}

	public override void attack2(){
		instantiateBullet (bullet2, 0, damage2, range2, projectileSpeed2);
	}

}

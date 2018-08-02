using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class should contain basic funtions to spawn bullets and have them go in the
//direction the player aims.

public class RangedWeaponClass : WeaponClass {

	public GameObject bulletSpawnPoint;
	public GameObject bullet1;
	public GameObject bullet2;

	public virtual void instantiateBullet(GameObject projectile, float angle){
		Transform bulletSpawned;
		bulletSpawned = Instantiate (projectile.transform, bulletSpawnPoint.transform.position, Quaternion.identity);
		bulletSpawned.Rotate (0, bulletSpawnPoint.transform.rotation.eulerAngles.y+angle, 0);

	}

	public override void attack1(){
		instantiateBullet (bullet1, 0);
	}

	public override void attack2(){
		instantiateBullet (bullet2, 0);
	}

}

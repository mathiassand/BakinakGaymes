using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRangeWeapon2 : RangedWeaponClass {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		listen ();
	}

	public override void attack2(){
		instantiateBullet (bullet2, 0);
		instantiateBullet (bullet2, -10);
		instantiateBullet (bullet2, 10);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this class should contain all the basics for every weapon, like damge and so on.
//Should also contain function that responds on the input of mouse 1 and mouse 2.

public class WeaponClass : MonoBehaviour {

	public float damage;
	public float attackSpeed;
	public float coolDown;

	public void action(){
		coolDown += 1 * Time.deltaTime;
		if (Input.GetMouseButton (0)) {
			if (coolDown >= attackSpeed) {
				attack ();
				coolDown = 0;
			}
	}
  }
	public virtual void attack(){

	}
}

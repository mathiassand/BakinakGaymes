using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this class should contain all the basics for every weapon, like damge and so on.
//Should also contain function that responds on the input of mouse 1 and mouse 2.

public class WeaponClass : MonoBehaviour {

	public float attackSpeed1;
	public float attackSpeed2;
	float coolDown1;
	float coolDown2;

	public virtual void action1(float attackSpeed){
		coolDown1 += 1 * Time.deltaTime;
		if (Input.GetMouseButton (0)) {
			if (coolDown1 >= attackSpeed) {
				attack1 ();
				coolDown1 = 0;
			}
		}
  	}

	public virtual void action2(float attackSpeed){
		coolDown2 += 1 * Time.deltaTime;
		if (Input.GetMouseButton (1)) {
			if (coolDown2 >= attackSpeed) {
				attack2 ();
				coolDown2 = 0;
			}
		}
	}

	public void listen(){
		action1 (attackSpeed1);
		action2 (attackSpeed2);
	}

	public virtual void attack1(){

	}

	public virtual void attack2(){

	}
}

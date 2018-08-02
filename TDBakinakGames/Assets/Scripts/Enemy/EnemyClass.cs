using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour {

	//variables
	public float health;
	public float speed;
	public float damage;
	public float attackSpeed;



	//Functions

	public virtual void die(){
		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public GameObject destroydVersion;

	 void OnCollisionEnter(Collision other)
	{
		// You probably want a check here to make sure you're hitting a zombie
		// Note that this is not the best method for doing so.
		if ( other.gameObject.CompareTag("player")){
			Instantiate (destroydVersion, transform.position, transform.rotation);
			Destroy (this.gameObject);
			Debug.Log ("Collide");
		}
	}
}

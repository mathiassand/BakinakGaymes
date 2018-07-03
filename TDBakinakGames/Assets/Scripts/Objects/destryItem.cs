using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destryItem : MonoBehaviour {


	public int expire;
	// Use this for initialization
	void Start () {
		StartCoroutine (DeleteObject ());
	}
	
	// Update is called once per frame
	void Update () {


	}
	IEnumerator DeleteObject (){
		yield return new WaitForSeconds (expire);
		Destroy (this.gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilCleanUp : MonoBehaviour {

	// Use this for initialization
	//private Flower flower;

	void Start() {
		//flower = GetComponent<Flower> ();
	}

	public void OnCollisionEnter (Collision col) {
		if(col.gameObject.tag != "GardenBox" )
		{
			Destroy(gameObject);
		}

	}
}

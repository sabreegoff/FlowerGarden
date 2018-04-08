using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	public int type; 


	void OnTriggerEnter(Collider col){
//		if (col.gameObject.GetComponent<Loot> () != null && col.gameObject.tag == "Player") {
//			col.gameObject.GetComponent<Loot> ().PickupItem (type);
//			Destroy (gameObject);
//		}
		if(col.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

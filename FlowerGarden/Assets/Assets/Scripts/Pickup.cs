using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {
	public Loot.Type type; 
	public int amount;

	void OnTriggerEnter(Collider col){
		if(col.gameObject.GetComponent<Loot> () != null && col.gameObject.tag == "Player")
			
		{
			col.gameObject.GetComponent<Loot> ().AddLoot(type, amount);
			GetComponentInParent<PickupSpawn>().PickupLooted ();
			Destroy(gameObject);
		}
	}
}

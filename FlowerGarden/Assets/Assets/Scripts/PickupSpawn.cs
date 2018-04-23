using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour {

	// Use this for initialization

	[SerializeField]
	public GameObject[] pickups;

	void Start () {
		SpawnPickup ();	
	}

	// Update is called once per frame
	void Update () {

	}

	void SpawnPickup () {
		//instantiate random pickup
		Instantiate(pickups[Random.Range(0, pickups.Length)], transform);
	}

	IEnumerator RespawnPickup() {
		yield return new WaitForSeconds (20);
		SpawnPickup (); 
	}

	public void PickupLooted () {
		StartCoroutine ("RespawnPickup");
	}

}

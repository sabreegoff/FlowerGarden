using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour {

	// Update is called once per frame
	public GameObject waterPrefab;
	public Transform waterPosition;

	Animator animator;

	private Loot loot;

	void Start() {
		animator = GetComponent<Animator> ();
		loot = GetComponentInParent<Loot> ();
	}

	void Update () {
		animator.SetBool ("Pouring", Input.GetKey (KeyCode.Q));
	}

	public void Pour () {
		if (!loot.HasLoot (Loot.Type.water)) {
			return;
		}

		loot.ConsumeLoot (Loot.Type.water);
		var spawnOffset = new Vector3 (Random.Range (-1, 1), 0, Random.Range (-1, 1)) * 0.1f;
		var clone = Instantiate(waterPrefab, 
			waterPosition.position + 
			waterPosition.right * spawnOffset.x + 
			waterPosition.up * spawnOffset.z, 
			waterPosition.rotation);
		clone.GetComponent<Rigidbody> ().velocity = -waterPosition.forward * 2;
		Destroy (clone, 2.0f);
	}
}


// Garden sheers 

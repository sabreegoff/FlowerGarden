using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour {

	// Update is called once per frame
	public GameObject soilPrefab;
	private Loot loot;

	//private GameObject flowerClone;
	//private Flower flower; 
	//public GameObject flowerPrefab;

	void Start() {
		loot = GetComponentInParent<Loot>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Q)) {
			Plant ();
		}
	}

	void Plant () {
		if (!loot.HasLoot (Loot.Type.seed)) {
			return;
		}

		Debug.Log ("Plant");
		Instantiate (soilPrefab, Camera.main.transform.position + (Camera.main.transform.forward*4), Quaternion.identity);
		loot.ConsumeLoot (Loot.Type.seed);
	}


}

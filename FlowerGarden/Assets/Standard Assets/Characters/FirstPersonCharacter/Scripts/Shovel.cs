using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour {

	// Update is called once per frame
	public GameObject soilPrefab;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Q)) {
			Plant ();
		}
	}

	void Plant () {
		Debug.Log ("Plant");
		Instantiate (soilPrefab, Camera.main.transform.position + (Camera.main.transform.forward*10), Quaternion.identity);
	}


}

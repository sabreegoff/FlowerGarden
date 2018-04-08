using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour {

	// Update is called once per frame
	//public GameObject waterPrefab;


	void Update () {
		if(Input.GetKeyDown(KeyCode.Q)) {
			Water ();
		}
	}

	void Water () {
		Debug.Log ("Water");
		//Instantiate (waterPrefab, new Vector3(transform.position.x, transform.position.y +1, transform.position.z+1), Quaternion.identity);
		gameObject.GetComponent<Animation>().Play ();
	}
}

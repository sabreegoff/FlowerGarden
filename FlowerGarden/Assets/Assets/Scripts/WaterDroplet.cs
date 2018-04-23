using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDroplet : MonoBehaviour {

	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion dirQ = Quaternion.LookRotation (-rb.velocity);
		Quaternion slerp = Quaternion.Slerp (transform.rotation, dirQ, rb.velocity.magnitude * 100 * Time.deltaTime);
		rb.MoveRotation(slerp);
	}
		
	public void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Soil") {
			col.gameObject.GetComponentInParent<Flower> ().waterHealth += 1;
		}
	}	
}

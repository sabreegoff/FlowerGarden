using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCanAligner : MonoBehaviour {

	new public Camera camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
//		var localY = transform.localEulerAngles.y;
//		transform.up = Vector3.up;
//		var forward = transform.forward;
//		forward.z = 0;
//		var lookRotation = Quaternion.LookRotation(forward, Vector3.up);
//		transform.localRotation = Quaternion.Slerp(transform.localRotation, lookRotation, 100 * Time.deltaTime);
//		transform.RotateAround(transform.position, transform.up, localY);
//		var rotation = transform.rotation;
//		var angles = rotation.eulerAngles;
//		angles.x = -camera.transform.rotation.eulerAngles.x;
//		rotation.eulerAngles = angles;
//		transform.rotation = rotation;
		Vector3 localUp = transform.up;
		// Building the world (not-local) rotation from child's local z-axis to parent's y-axis
		Quaternion verticalDown = Quaternion.FromToRotation(localUp, Vector3.up) * transform.rotation;
		// apply it
		transform.rotation = Quaternion.Slerp(transform.rotation, verticalDown, Time.deltaTime * 100.0f);
	}
}

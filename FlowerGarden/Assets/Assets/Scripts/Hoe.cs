using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoe : MonoBehaviour
{

	public Animation animation;
	private Loot loot;
	private Transform mainCamera;
	private Flower activeTarget;

	void Start()
	{
		animation = GetComponent<Animation>();
		loot = GetComponentInParent<Loot>();
		mainCamera = GameObject.FindWithTag("MainCamera").transform;
	}

	private void updateActiveTarget()
	{
		RaycastHit hit;
		int layerMask = 1 << LayerMask.NameToLayer("Stem");
		float distance = 0.8f * 5;
		Flower target = null;
		var ray = new Ray(mainCamera.position, mainCamera.forward);

		Debug.DrawRay(ray.origin, ray.direction * distance);
		if (Physics.SphereCast(ray,
		                       .25f * 5, 
		                       out hit,
		                       distance,
		                       layerMask,
		                       QueryTriggerInteraction.Collide)) {
			target = hit.collider.gameObject.GetComponentInParent<Flower>();
		}

		if (activeTarget != null && target != activeTarget) {
			activeTarget.setHighlighted(false);
		}

		if (target != null) {
			target.setHighlighted(true);
		}

		activeTarget = target;
	}

	void Update()
	{
		updateActiveTarget();

		if (activeTarget != null && Input.GetKeyDown(KeyCode.Q)) {
			animation.Play();
			loot.AddLoot(Loot.Type.flower, 1);
			Destroy(activeTarget.transform.root.gameObject, 10);
			Destroy(activeTarget.gameObject);
			activeTarget = null;
		}
	}

//	void OnTriggerEnter(Collider col)
//	{
//		if (col.gameObject.tag == "Stem") {
//			Debug.Log("saw");
//
//		}
//	}
}

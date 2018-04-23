using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HandFlower : MonoBehaviour {


	// Update is called once per frame
	public GameObject[] boquetteFlowers;
	private GameObject currentFlower;
	private Loot loot;
	private Transform mainCamera;
	public GameObject winText;
	//public GameObject moreText;

//	public Text moreText;
//	public Text winText;


//	[SerializeField]
//	private GameObject target;

	private HUD hud;

	void Start()
	{
//		winText.enabled = false; 
		loot = GetComponentInParent<Loot>();
//		mainCamera = GameObject.FindWithTag("MainCamera").transform;
	}

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Q)) {
			AddFlower();


		}


	}
	public void AddFlower()
	{
		if (loot.GetLoot(Loot.Type.flower) > 0) {
			for ( int i = 0; i < boquetteFlowers.Length; i++ ) {
				if (boquetteFlowers[i].activeInHierarchy) {
					if (i == 1) {
						Debug.Log("win");
//						moreText.SetActive(false);		
						winText.SetActive(true);
					}
					continue;
				} else {
					currentFlower = boquetteFlowers[i];
				}
			}
				currentFlower.SetActive(true);
				loot.ConsumeLoot(Loot.Type.flower);
			
		} else {
			//moreText.SetActive(true);
			Debug.Log("noloot");
		}


	}
////	void Update () {
////
////		if(Input.GetKeyDown(KeyCode.Q)) {
////			Place ();
////		}
////	}
//
//
//
//	private void updateActiveTarget()
//	{
//		RaycastHit hit;
//		int layerMask = 1 << LayerMask.NameToLayer("Vase");
//		float distance = 0.8f * 5;
////		GameObject target = null;
////		GameObject target = activeTarget;
//		var ray = new Ray(mainCamera.position, mainCamera.forward);
//
//		Debug.DrawRay(ray.origin, ray.direction * distance);
//		if (Physics.SphereCast(ray,
//		                       .25f * 5, 
//		                       out hit,
//		                       distance,
//		                       layerMask,
//		                       QueryTriggerInteraction.Collide)) {
////			//target = hit.collider.gameObject.GetComponentInParent<Flower>();
//////			target = hit.collider.gameObject.GetComponent("Vase");
////			target = activeTarget;
//			var renderers = GetComponentsInChildren<Renderer>();
//			foreach (var renderer in renderers) {
//				renderer.material.DisableKeyword("_EMISSION");
//				renderer.material.SetColor("_EmissionColor", Color.blue);
//			}
//		}
////
////		if (activeTarget != null) {
////			var renderers = GetComponentsInChildren<Renderer>();
////			foreach (var renderer in renderers) {
////				renderer.material.DisableKeyword("_EMISSION");
////				renderer.material.SetColor("_EmissionColor", Color.blue);
////			}
//////		}
////
////		if (target != null) {
////
////			var renderers = GetComponentsInChildren<Renderer>();
////			foreach (var renderer in renderers) {
////				renderer.material.EnableKeyword("_EMISSION");
////			}
////		}
////
////		activeTarget = target;
//	}

//	void Update()
//	{
//		updateActiveTarget();
//
//		if ( target != null && Input.GetKeyDown(KeyCode.Q)) {
////			loot.AddLoot(Loot.Type.flower, 1);
////			Destroy(activeTarget.transform.root.gameObject, 10);
////			Destroy(activeTarget.gameObject);
////			activeTarget = null;
//			for (int i = 0; i <= loot.GetLoot(Loot.Type.flower); i++ ) {
//				if (!boquetteFlowers[i].activeInHierarchy) {
//					boquetteFlowers[i].SetActive(true);
//					loot.ConsumeLoot (Loot.Type.flower);
//				}
//			}
//		}
//	}











//	void Place()
//	{
//
////		if (loot.GetLoot(Loot.Type.flower) == 1) {
////			boquetteFlowers[1].SetActive(true);
////		}
//
//		for ( int i = 0; i <= loot.GetLoot(Loot.Type.flower); i++ ) {
//			if (!boquetteFlowers[i].activeInHierarchy) {
//				boquetteFlowers[i].SetActive(true);
//				loot.ConsumeLoot (Loot.Type.flower);
//			}
//		}
//	}





}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour {

	// Use this for initialization
//	[SerializeField]
//	GameUI gameUI;

	[SerializeField]
	private int seeds;
	[SerializeField]
	private int water;
	[SerializeField]
	private int flowers;

	public Dictionary<string, int> lootTag;

	void Awake() {
		lootTag = new Dictionary<string, int> {
			{Constants.Shovel, seeds},
			{Constants.WateringCan, water},
			{Constants.Hoe, flowers},
		};
	}

	public void AddLoot(string tag, int loot) {
		if (!lootTag.ContainsKey (tag)) {
			Debug.LogError ("Opps");
		}
		lootTag [tag] += loot;
	}

	public bool HasLoot(string tag){
		return lootTag[tag] > 0;
	}

	public int GetLoot(string tag){
		return lootTag[tag];
	}

	public void ConsumeLoot(string tag){
		lootTag[tag]--;
	}



	private void PickupSeeds () {
		seeds += 1;
		if (seeds > 20) {
			seeds = 20;
		}
	}


	private void PickupWater () {
		water += 10; 
		if (water > 100) {
			water = 100;
		}
	}

	public void PickupItem(int pickupType){
		switch (pickupType) {
			case Constants.SeedsPickup:
				PickupSeeds ();
				break;
			case Constants.WaterPickup:
				PickupWater ();
				break;
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

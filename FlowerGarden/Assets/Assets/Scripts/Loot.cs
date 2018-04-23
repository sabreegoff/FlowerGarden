using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour {

	public enum Type {
		seed, water, flower
	}

	// Use this for initialization
//	[SerializeField]
//	GameUI gameUI;

	[SerializeField]
	private int seeds;
	[SerializeField]
	private int water;
	[SerializeField]
	private int flowers;

	[SerializeField]
	private HUD hud;

	public Dictionary<Type, int> lootTag;

	void Awake() {
		lootTag = new Dictionary<Type, int> {
			{Type.seed, 0},
			{Type.water, 0},
			{Type.flower, 0},
		};

		AddLoot (Type.seed, seeds);
		AddLoot (Type.water, water);
		AddLoot (Type.flower, flowers);

	}

	public void AddLoot(Type tag, int loot) {
		if (!lootTag.ContainsKey (tag)) {
			Debug.LogError ("Oops");
		}
		lootTag [tag] += loot;

		if (tag == Type.seed) {
			hud.setSeedCount (lootTag [tag]);
		}

		if (tag == Type.water) {
			hud.setWaterCount (lootTag [tag]);
		}
		if (tag == Type.flower) {
			hud.setFlowerCount (lootTag [tag]);
		}
	}

	public bool HasLoot(Type tag)
	{
		if (lootTag[tag] > 0) {
			//return lootTag[tag] > 0;
			return true;
		}
		return false;
	}

	public int GetLoot(Type tag){
		return lootTag[tag];
	}

	public void ConsumeLoot(Type tag){
		lootTag[tag]--;

		if (tag == Type.seed) {
			hud.setSeedCount (lootTag [tag]);

		}
		if (tag == Type.water) {
			hud.setWaterCount (lootTag [tag]);

		}
		if (tag == Type.flower) {
			hud.setFlowerCount (lootTag [tag]);
		}
	}
}

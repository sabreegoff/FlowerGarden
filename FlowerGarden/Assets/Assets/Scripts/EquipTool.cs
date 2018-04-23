using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipTool : MonoBehaviour {

	public enum Type {
		shovel, wateringCan, hoe, handFlower
	}

	public static Type activeToolType;
	public GameObject shovel;
	public GameObject wateringCan;
	public GameObject hoe;
	public GameObject handFlower;

	GameObject activeTool;

	[SerializeField]
	private HUD hud;

	private Loot loot;

	void Start () {
		activeToolType = Type.shovel;
		activeTool = shovel;
		loot = GetComponent<Loot>();
	} 

	void Update()
	{
		if (Input.GetKeyDown("1")) {
			loadTool(shovel);
			activeToolType = Type.shovel;
		} else if (Input.GetKeyDown("2")) {
			loadTool(wateringCan);
			activeToolType = Type.wateringCan;
		} else if (Input.GetKeyDown("3")) {
			loadTool(hoe);
			activeToolType = Type.hoe;
		} else if (Input.GetKeyDown("4")) {
			if (loot.GetLoot(Loot.Type.flower) == 0) {
				handFlower.SetActive(false);
				Debug.Log(loot.GetLoot(Loot.Type.flower));
			} else {
				loadTool(handFlower);
				activeToolType = Type.handFlower;
			}
		}

		hud.setWaterLevelVisible (activeToolType == Type.wateringCan);
	}

	public GameObject GetActiveTool () {
		return activeTool;
	}

	private void loadTool(GameObject tool) {
		shovel.SetActive (false);
		wateringCan.SetActive (false);
		hoe.SetActive (false);
		handFlower.SetActive (false);
		tool.SetActive (true);
		activeTool = tool;
	}
}

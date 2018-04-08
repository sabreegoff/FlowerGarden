using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipTool : MonoBehaviour {

	public static string activeToolType;
	public GameObject shovel;
	public GameObject wateringCan;
	public GameObject hoe;

	GameObject activeTool;

	void Start () {
		activeToolType = Constants.Shovel;
		activeTool = shovel;
	} 

	void Update () {
		if (Input.GetKeyDown ("1")) {
			loadTool (shovel);
			activeToolType = Constants.Shovel;
		}
		else if (Input.GetKeyDown ("2")) {
			loadTool (wateringCan);
			activeToolType = Constants.WateringCan;
		}
		else if (Input.GetKeyDown ("3")) {
			loadTool (hoe);
			activeToolType = Constants.Hoe;
		}
	}

	public GameObject GetActiveTool () {
		return activeTool;
	}

	private void loadTool(GameObject tool) {
		shovel.SetActive (false);
		wateringCan.SetActive (false);
		hoe.SetActive (false);
		tool.SetActive (true);
		activeTool = tool;
	}
}

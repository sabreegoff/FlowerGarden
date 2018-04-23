using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour {

	public Animation anim;
	public Loot.Type type; 
	// Use this for initialization
	public int waterHealth;
	public int flowerState;
	public GameObject sad;
	public GameObject content;
	public GameObject happy;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (waterHealth <= 25) {
			flowerState = 0;
			sad.SetActive (true);
			Grow ();
		} else if (waterHealth > 25 && waterHealth <= 50) {
			flowerState = 1;
			sad.SetActive (false);
			content.SetActive (true);
			Grow ();
		} else if (waterHealth > 50 && waterHealth <= 75) {
			flowerState = 2;
			content.SetActive (false);
			happy.SetActive (true);
			Grow ();
		} else if (waterHealth > 100) {
			flowerState = 3;
			happy.SetActive (false);
			sad.SetActive (true);
			Grow ();
		}

		
	}

	public void Grow () {
		foreach (AnimationState state in anim) {
			if (flowerState == 1) {
				state.speed = 0.005f;
			}
			else if (flowerState == 2) {
				state.speed = 0.1f;
			} else {
				state.speed = 0.001f;
			}
		}
	}

	public void setHighlighted(bool highlighted)
	{
		var renderers = GetComponentsInChildren<Renderer>();
		foreach (var renderer in renderers) {
			if (highlighted) {
				renderer.material.EnableKeyword("_EMISSION");
			} else {
				renderer.material.DisableKeyword("_EMISSION");
			}
			renderer.material.SetColor("_EmissionColor", Color.blue);
		}
	}
}


//all flowers are affected by water (need to just affect clone)
//not counting flower cuts properly
//create points for flowers cut
//make flowers die when sad. 
//make water evaporate after time. 
//once we get 12 flowers, make a boquete
//respawn prefabs

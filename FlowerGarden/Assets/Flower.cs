using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour {

	public Animation anim;

	// Use this for initialization
	void Start () {
		foreach (AnimationState state in anim) {
			state.speed = 0.1f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

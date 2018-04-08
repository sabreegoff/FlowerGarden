using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour {

	// Use this for initialization
	public const string Shovel = "Shovel";
	public const string WateringCan = "WateringCan";
	public const string Hoe = "Hoe";

	public const int SeedsPickup = 1;
	public const int WaterPickup = 2;

	public static readonly int[] AllPickupTypes = new int[2] {
		SeedsPickup,
		WaterPickup
	};
}

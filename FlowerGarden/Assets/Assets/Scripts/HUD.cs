using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	[SerializeField]
	private Text seedCountText;

	[SerializeField]
	private Text flowerCountText;

	[SerializeField]
	private Text moreText;
	[SerializeField]
	private Text winText;

	[SerializeField]
	private Image waterProgressBar;

	[SerializeField]
	private CanvasGroup waterLevelGroup;

	public void setSeedCount(int count) {
		seedCountText.text = count.ToString ();
	}
	public void setFlowerCount(int count) {
		flowerCountText.text = count.ToString ();
	}

	public void setWaterCount(int count) {
		float percent = (float)count / 1000.0f;
		waterProgressBar.fillAmount = percent;
	}
	public void win()
	{
		winText.enabled = true; 
	}
	public void more()
	{
		moreText.enabled = true; 

	}




	public void setWaterLevelVisible(bool visible) {
		if (visible) {
			waterLevelGroup.alpha = 1;
		} else {
			waterLevelGroup.alpha = 0;
		}
	}
}

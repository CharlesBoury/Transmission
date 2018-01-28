using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heure : MonoBehaviour {

	public Slider mainSlider;
	public Text displayTime;

	public float vitesse = 60;

	void Start () {
		mainSlider.value = 0;
	}
	void Update () {
		mainSlider.value += Time.deltaTime * vitesse / (3600 * 24);

		int currentMinute = (int) Mathf.Round(mainSlider.value * 60 * 24);

		displayTime.text = (currentMinute / 60 < 10 ? "0" : "") + (currentMinute / 60) + "h" + (currentMinute % 60 < 10 ? "0" : "") + (currentMinute % 60);
	}
}

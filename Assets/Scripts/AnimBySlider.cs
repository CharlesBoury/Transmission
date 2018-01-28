using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimBySlider : MonoBehaviour {

	public Slider mainSlider;
	Animator animator;
	public string nomDeLanim;

	void Start () {
		animator = GetComponent<Animator>();
	}

	void Update () {
		animator.Play(nomDeLanim, -1, mainSlider.value);
	}
}

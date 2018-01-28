using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dudes : MonoBehaviour {

	public Slider mainSlider;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
	}

	void Update () {
		animator.Play("La vie des gens", -1, mainSlider.value);
		// if (mainSlider.value <= 0.25F){
		// 	animator.Play("La vie des gens 0", -1, mainSlider.value * 4);
		// }
		// else if (mainSlider.value <= 0.5F){
		// 	animator.Play("La vie des gens 1", -1, (mainSlider.value - 0.25F) * 4);
		// }
		// else if (mainSlider.value <= 0.75F){
		// 	animator.Play("La vie des gens 2", -1, (mainSlider.value - 0.5F) * 4);
		// }
		// else {
		// 	animator.Play("La vie des gens 3", -1, (mainSlider.value - 0.75F) * 4);
		// }
	}
}

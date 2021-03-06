﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionBySpeed : MonoBehaviour {

	public Transform bulle;

	Vector3 previousPos;
	Animator animator;

	void Start() {
		previousPos = Vector3.zero;
		animator = GetComponent<Animator>();
		animator.SetFloat("cycleOffset", Random.value);
	}

	void Update () {
		Vector3 delta = transform.position - previousPos;

		if (delta.x == 0) {
			animator.SetBool("marche", false);
		} else animator.SetBool("marche", true);
		if (delta.x > 0) {
			transform.localScale = new Vector3(1,1,1);
			bulle.localScale = new Vector3(1,1,1);
		}
		else if (delta.x < 0) {
			transform.localScale = new Vector3(-1,1,1);
			bulle.localScale = new Vector3(-1,1,1);
		}

		previousPos = transform.position;
	}
}

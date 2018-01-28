using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionBySpeed : MonoBehaviour {

	Vector3 previousPos;
	public Transform tete;
	public Transform corps;

	void Start() {
		previousPos = Vector3.zero;
	}

	void Update () {
		Vector3 delta = transform.position - previousPos;

		if (delta.x > 0) {
			tete.localScale = new Vector3(-1,1,1);
			corps.localScale = new Vector3(-1,1,1);
		}
		else if (delta.x < 0) {
			tete.localScale = new Vector3(1,1,1);
			corps.localScale = new Vector3(1,1,1);
		}

		previousPos = transform.position;
	}
}

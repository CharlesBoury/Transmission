using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RDV {
	public float time;
	public Vector2 position;

	public RDV() {
		time = 0;
		position = Vector2.zero;
	}

	public RDV(float t, float x, float y) {
		time = t;
		position = new Vector2(x,y);
	}
}
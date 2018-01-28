using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
[RequireComponent(typeof(Renderer))]
public class OrderByY : MonoBehaviour {

	private new Renderer renderer;

	void OnEnable () {
		renderer = GetComponent<Renderer>();
	}

	void Update () {
		renderer.sortingOrder = (int) (-transform.position.y * 1000);
	}
}
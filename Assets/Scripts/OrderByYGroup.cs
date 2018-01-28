using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
[RequireComponent(typeof(SortingGroup))]
public class OrderByYGroup : MonoBehaviour {

	private SortingGroup sortingGroup;

	void OnEnable () {
		sortingGroup = GetComponent<SortingGroup>();
	}

	void Update () {
		sortingGroup.sortingOrder = (int) (-transform.position.y * 1000);
	}
}
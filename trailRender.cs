using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailRender : MonoBehaviour {
	TrailRenderer tr;

	void Start () {
		tr = this.gameObject.GetComponent<TrailRenderer>();
		tr.sortingLayerName = "n";
	}

	// Update is called once per frame
	void Update () {

	}
}

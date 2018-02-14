using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMeow : MonoBehaviour {
	Vector3 thisSize;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		thisSize = this.transform.localScale;
		if(thisSize.y > 0){
			thisSize.x -= 0.05f;
			thisSize.y -= 0.05f;
		}
		transform.localScale = thisSize;
	}
}

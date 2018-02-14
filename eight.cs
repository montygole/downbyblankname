using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		changeColour();
	}


	void changeColour(){
		float t = Mathf.PingPong(Time.time, 30.0f) / 30.0f;
		this.GetComponent<Camera>().backgroundColor = Color.Lerp(Color.blue, Color.red, t);
	}

	// Update is called once per frame
	void Update () {

	}
}

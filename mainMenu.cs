using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour {

	public GameObject circle;
	Vector2 thistrans;

	// Use this for initialization
	void Start () {
		InvokeRepeating("circs", 2.0f, 1.5f);
	}

	void circs(){
		Instantiate(circle, new Vector2(Random.Range(-2, 2.3f), 6.75f), Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {

	}
}

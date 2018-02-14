using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("arcadeScore").ToString();
	}

	// Update is called once per frame
	void Update () {

	}
}

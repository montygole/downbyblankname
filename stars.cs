using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour {
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	// Use this for initialization
	void Start () {
		starSystem();
	}

	// Update is called once per frame
	void starSystem () {
		if(PlayerPrefs.GetInt("Level" + this.gameObject.tag + "Stars") == 1){
			star1.GetComponent<UnityEngine.UI.Image>().color = new Color(52/255, 73/255, 94/255,255);
		}if(PlayerPrefs.GetInt("Level" + this.gameObject.tag + "Stars") == 2){
			star1.GetComponent<UnityEngine.UI.Image>().color = new Color(52/255, 73/255, 94/255,255);
			star2.GetComponent<UnityEngine.UI.Image>().color = new Color(52/255, 73/255, 94/255,255);
		}if(PlayerPrefs.GetInt("Level" + this.gameObject.tag + "Stars") == 3){
			star1.GetComponent<UnityEngine.UI.Image>().color = new Color(52/255, 73/255, 94/255,255);
			star2.GetComponent<UnityEngine.UI.Image>().color = new Color(52/255, 73/255, 94/255,255);
			star3.GetComponent<UnityEngine.UI.Image>().color = new Color(52/255, 73/255, 94/255,255);
		}
	}
}

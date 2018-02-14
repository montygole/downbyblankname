using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforms : MonoBehaviour {
	Vector3 thisSize;
	public GameObject player;
	float a = 255.0f;
	public SpriteRenderer me;
	public float offset;
	//public SpriteRenderer me2;

	Color thisColor;
	// Use this for initialization
	void Start () {
		thisColor = me.color;
	}

	// Update is called once per frame
	void Update () {
		thisSize = transform.localScale;
		//Debug.Log(transform.position);
		if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex != 8){
			if(transform.position.y >= player.transform.position.y + offset || statManager.over == true || arcadeStat.isOver){

			// 	if(thisSize.x > 0){
			// 		thisSize.x -= 0.05f;
			// 		}
			// 	else Destroy(this.gameObject);
			// }
			// transform.localScale = thisSize;
			if(a > 0){
					me.color = new Color(thisColor.r, thisColor.g, thisColor.b, a/255);
					//me2.color = new Color(0.18039215686274f, 0.8f, 0.52156862745098f, a/255);
		a-=5f;
		//Debug.Log(me2.color.a);
		}
		if(a <= 0){
			this.gameObject.SetActive(false);
		}
	}
}
	else{
		if(transform.position.y <= player.transform.position.y - 1.4f|| statManager.over == true){

		// 	if(thisSize.x > 0){
		// 		thisSize.x -= 0.05f;
		// 		}
		// 	else Destroy(this.gameObject);
		// }
		// transform.localScale = thisSize;
		if(a > 0){
			if(this.gameObject.tag == "bad"){
				me.color = new Color(1, 1, 1, a/255);
				//me2.color = new Color(1, 1, 1, a/255);
			}
			else if(this.gameObject.tag == "blue"){
				me.color = new Color(0, 23/255, 1, a/255);
			}
			else{
				me.color = new Color(0.18039215686274f, 0.8f, 0.52156862745098f, a/255);
				//me2.color = new Color(0.18039215686274f, 0.8f, 0.52156862745098f, a/255);

			}
	a-=5f;
	//Debug.Log(me2.color.a);
	}
	if(a <= 0){
		this.gameObject.SetActive(false);
	}
}

	}
	}

}

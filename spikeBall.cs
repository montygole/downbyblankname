using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeBall : MonoBehaviour {
	Vector3 thisPos;
	bool dirRight = true;
	float speed = 1.0f;
	// Use this for initialization
	void Start () {
		//this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(6.0f, 0));
	}

	// Update is called once per frame
	void Update () {
		thisPos.y = transform.position.y;
		//Debug.Log(dirRight);
		//if(this.gameObject.CompareTag("bad")){
			if (dirRight){
							transform.Translate (Vector2.right * speed * Time.deltaTime);
					}
					else if(dirRight == false){
							transform.Translate (-Vector2.right * speed * Time.deltaTime);
				  }



					if(transform.position.x >= 2.812f) {
							thisPos.x = -3.0f;
							transform.position = thisPos;
					}
		//}
		// else {
		// 	if (dirRight)
		// 					transform.Translate (Vector2.right * speed * Time.deltaTime);
		// 			else
		// 					transform.Translate (-Vector2.right * speed * Time.deltaTime);
		//
		// 			if(transform.position.x >= 1.55f) {
		// 					dirRight = false;
		// 			}
		//
		// 			if(transform.position.x <= 0.8f) {
		// 					dirRight = true;
		// 			}
		// }

	}
}

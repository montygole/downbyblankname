using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arcadeCollisions : MonoBehaviour {

	public static bool canStart = false;

	public static bool addScore = false;

	Vector2 thisPos;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter2D(Collider2D collObj){
		if(collObj.gameObject.CompareTag("7th")){
			canStart = true;
		}
		if(collObj.gameObject.CompareTag("point")){
				//arcadeStat.startScore += 1;

				//Debug.Log();
			}
			if(collObj.gameObject.CompareTag("restart")){
				arcadeStat.timeOther += 0.05f;
				addScore = true;
					//arcadeStat.startScore += 1;
					arcade.restart = true;
					arcadeStat.timeRestart = true;
					canStart = false;
				}
	}

	void OnCollisionEnter2D(Collision2D collObj){
			if(collObj.gameObject.CompareTag("7th")){
				canStart = true;
			}
	}

	// Update is called once per frame
	void Update(){
		thisPos = transform.position;
		if(transform.position.x > 2.54f){
			this.GetComponent<TrailRenderer>().time = 0;
				thisPos.x = -2.455f;
				transform.position = thisPos;
					this.GetComponent<TrailRenderer>().time = 4.39f;
		}
		else if(transform.position.x < -2.455f){
			this.GetComponent<TrailRenderer>().time = 0;
				thisPos.x = 2.54f;
				transform.position = thisPos;
					this.GetComponent<TrailRenderer>().time = 4.39f;
		}
	}
}

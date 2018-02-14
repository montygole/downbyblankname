using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {
	bool isTouched = false;
	Vector2 thisPos;
	public GameObject timeAdd;
	public AudioSource getIt;


		void Update(){
			thisPos = transform.position;
			if(transform.position.x > 2.54f){
				this.GetComponent<TrailRenderer>().enabled = false;
					thisPos.x = -2.455f;
					thisPos.y += 0.000009f;
					transform.position = thisPos;

						this.GetComponent<TrailRenderer>().enabled = true;
			}
			else if(transform.position.x < -2.455f){
				this.GetComponent<TrailRenderer>().enabled = false;
					thisPos.x = 2.54f;
					thisPos.y += 0.000009f;					
					transform.position = thisPos;

						this.GetComponent<TrailRenderer>().enabled = true;
			}
		}
		void OnTriggerEnter2D(Collider2D collObj){
			//
			//Debug.Log("1/2");
			if(collObj.gameObject.CompareTag("point")){
				isTouched = true;
				if(isTouched){
					statManager.startScore -= 1;
					//Debug.Log("2/2");
				}
				isTouched = false;
				Destroy(collObj.gameObject);
				return;
			}
			else if(collObj.gameObject.CompareTag("bad") || collObj.gameObject.CompareTag("badLeft") || collObj.gameObject.CompareTag("badRight")){
				GameObject.Find("Main Camera").GetComponent<statManager>().gameOver();
				statManager.over = true;
			}
			else if(collObj.gameObject.CompareTag("blue")){
				getIt.Play();
				statManager.time += 0.0166666666666667f;

				Destroy(collObj.gameObject);

				Instantiate(timeAdd, this.transform.position, Quaternion.identity);
			}
		}
}

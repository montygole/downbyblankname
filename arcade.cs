using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arcade : MonoBehaviour {

	public static bool restart;

	public GameObject first;

	public int startCap = 4;

	public GameObject square1;

	public GameObject square2;

	public GameObject player;

	public static float score = 4;

	Vector3 thisSize;

	GameObject firstBoi;

	public GameObject triCoin;

	float maxVel = 107.32f;

	int speed = 200;

	public Collider playerCollider;

	float baseY = -1.0f;

	public float camSpeed = 0;

	public GameObject computer;

	GameObject secondBoi;

	public GameObject spikePlatform;

	Vector3 camPos;

	public GameObject badBall;

	public GameObject bad1;

	Vector2 playerPos;

	GameObject newPl;

	int spawned = 0;

	int badHow = 3;

	 int badHowPoint = 0;

	 public GameObject restartTrigger;



	Vector3 mousePos;

	void Start () {
		score = 4;
		spawned = 0;

		restart = true;

		
		//InvokeRepeating("makeNewObstacle", 0.5f, 0.5f);
	}

	void makeNewObstacle(){

		Vector3 clonePos = new Vector3(Random.Range(-4.78f, -0.48f), baseY, 0);
		if(spawned < score && restart){

		clonePos = new Vector3(Random.Range(-4.78f, -0.48f), baseY, 0);
		if(spawned == 0){
			firstBoi = Instantiate(first, clonePos, Quaternion.identity);

			baseY -= Random.Range(1.0f, 2.0f);
		}
		firstBoi = Instantiate(square1, clonePos, Quaternion.identity);
		baseY -= Random.Range(1.0f, 2.0f);
		spawned +=1;
	}
	else if(spawned == score){
		firstBoi = Instantiate(restartTrigger, clonePos, Quaternion.identity);
		baseY -= 10;
		restart = false;
		spawned = 0;
		score += 1;
	}
	}


	void Update () {

		if(transform.position.x >= 2.812f) {
				playerPos.x = -3.0f;
				transform.position = playerPos;
		}
		makeNewObstacle();
		// if(spawned < score){
		// 		Vector3 clonePos = new Vector3(Random.Range(-4.78f, -0.48f), baseY, 0);
		// 		firstBoi = Instantiate(square1, clonePos, Quaternion.identity);
		//
		// 		if(spawned < score){
		// 		spawned +=1;
		// 	}
		// 	if(spawned == startCap){
		// 		//firstBoi.GetComponent<SpriteRenderer>().color = new Color(0.2f, 0.8, 0.20f, 1);
		// 		Debug.Log("Norm");
		// 	}
		//
		//
		//
		//
		//
		//
		// 			if(Random.Range(1,6) == 4){
		//
		// 				GameObject spikeMan = Instantiate(badBall, new Vector3(-2.33f, baseY - 1, 0), Quaternion.identity);
		//
		// 			//Debug.Log("meow");
		// 			}
		// 			else badHow++;
		//
		// 		baseY -= Random.Range(1.0f, 2.0f);
		//
		//
		//
		// 			if(Random.Range(1, 6) == 2 && spawned < startCap + 1){
		// 				Instantiate(bad1, new Vector3(0.25f, baseY-1.0f, 0), Quaternion.identity);
		// 				baseY -= Random.Range(1.0f, 2.0f) + 3;
		// 				if(spawned < score){
		// 					spawned += 2;
		// 			}
		// 			if(spawned == startCap){
		// 				//firstBoi.GetComponent<SpriteRenderer>().color = new Color(0.2f, 0.8, 0.20f, 1);
		// 				Debug.Log("treehouse");
		// 			}
		// 			}
		//
		//
		//
		// 			if(Random.Range(1,5) == 2){
		// 				Instantiate(triCoin, new Vector2(Random.Range(clonePos.x - 1.47f, clonePos.x + 9), clonePos.y + 0.2f), Quaternion.identity);
		// 				//baseY -= Random.Range(1.0f, 2.0f);
		// 			}
		//
		// 			if(Random.Range(1,7) == 2){
		// 				//clonePos = new Vector3(Random.Range(-4.78f, -0.48f), baseY, 0);
		// 				Instantiate(spikePlatform, new Vector3(clonePos.x, baseY + 0.7f, 0), Quaternion.identity);
		// 				baseY -= Random.Range(1.0f, 2.0f);
		// 				if(spawned < score){
		// 					spawned += 1;
		// 				}
		// 			}
		//
		//
		// 		//Debug.Log(spawned);
		// }
		// else{
		// 	//restart = true;
		// 	Debug.Log("its");
		// 	score += 1;
		// 	startCap += 1;
		// 	baseY -= 15;
		// 	spawned = 0;
		// 	Debug.Log(spawned);
		// }


		float x = Input.GetAxis("Horizontal") * Time.deltaTime * 13.0f;
		player.transform.Translate(x, 0, 0);
		playerPos = player.transform.position;


		// camPos = transform.position;
		camPos.y = player.transform.position.y;
		camPos.z = -20;
		//if(camSpeed < 1.0f) camSpeed -= 0.00001f;
		transform.position = camPos;
		bool canStrain = true;
		if (Input.GetMouseButton(0))
			 {
				 if(canStrain){
					 player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
					 player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
					 canStrain = false;
				 }
					 mousePos = Input.mousePosition;
           mousePos = Camera.main.ScreenToWorldPoint(mousePos);

					 if(mousePos.x > 0){
						 if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 6){
							 player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
						 }
						 else{

						player.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
					}
						// if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 6){
						// 	playerPos.x -= 0.075f;
						// }
						// else{
						//   playerPos.x += 0.075f;
						// }
						//
						//   player.transform.position = playerPos;

					 }
					 else if(mousePos.x < 0){
						 if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 6){
						 	player.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
						 }
						 else{

						 player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
						 }
					// 	 if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 6){
 				// 			playerPos.x += 0.075f;
 				// 		}
					// 	else{
					// 	  playerPos.x -= 0.075f;
					// 	}
					 //
					// 	  player.transform.position = playerPos;
					 //
					  }

			 }
		  else if(Input.GetMouseButtonUp(0)){
				 canStrain = true;
			  }

	}
	void FixedUpdate(){
		player.GetComponent<Rigidbody2D>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, maxVel);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class functionalitty : MonoBehaviour {
	public GameObject square1;

	public GameObject square2;

	public GameObject player;

	public int score;

	Vector3 thisSize;
	int eSpawned = 0;
	public int eScore = 10;

	GameObject firstBoi;

	public GameObject triCoin;

	float maxVel = 115.32f;

	int speed = 225;

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

	 public GameObject things;
	 int m = 10;

	 int baseYy = 0;



	Vector3 mousePos;

	void Start () {
		//InvokeRepeating("makeNewObstacle", 0.5f, 0.5f);
	}

	void makeNewObstacle(){
		Vector3 clonePos = new Vector3(Random.Range(-6.83f, -2.9f), baseY, 0);

		//newPl=Instantiate(square1, clonePos, Quaternion.identity);
		baseY -= Random.Range(1.0f, 2.0f);
	}


	void Update () {
		if(transform.position.x >= 2.812f) {
				playerPos.x = -3.0f;
				transform.position = playerPos;
		}
		if(eSpawned < eScore && UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 9){
			Vector3 clonePo = new Vector3(Random.Range(-6.83f, -2.9f), baseYy, 0);
			baseYy -= 1;
			clonePo = new Vector3(Random.Range(-4.78f, -0.48f), baseYy, 0);
			firstBoi = Instantiate(square1, clonePo, Quaternion.identity);
			if(spawned < score){
			eSpawned +=1;
		}
		if(eSpawned >= eScore){
			if(m >= 0){
				Instantiate(things, new Vector2(0, baseYy), Quaternion.identity);
			}

		}

		}
		if(spawned < score && UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex != 9){
				Vector3 clonePos = new Vector3(Random.Range(-4.78f, -0.48f), baseY, 0);
				firstBoi = Instantiate(square1, clonePos, Quaternion.identity);
				if(spawned < score){
				spawned +=1;
				}





				if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 4){
					if(Random.Range(1,6) == 4){

						GameObject spikeMan = Instantiate(badBall, new Vector3(Random.Range(-2.33f, 2.5f), baseY + 1.4f, 0), Quaternion.identity);

					Debug.Log("meow");
					}
					else badHow++;
				}

				if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 8){

				baseY += Random.Range(1.0f, 2.0f);

				}
				else{

				baseY -= Random.Range(1.0f, 2.0f);
			}

				if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 3 || UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 4 || UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 6){
					if(spawned > 10 && Random.Range(1, 3) == 2 && badHow > 0 && spawned < score && score - spawned != 1){
						if(score - spawned == 1)
						{
							Instantiate(square1, clonePos, Quaternion.identity);
						}
						else{
						Instantiate(bad1, new Vector3(0.25f, baseY-1.0f, 0), Quaternion.identity);
						baseY -= Random.Range(1.0f, 2.0f) + 3;
					}
						if(spawned < score){
							spawned += 2;
					}
						badHow -=1;
					}


				}

				if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex >= 5 && spawned < score){
					if(Random.Range(1,3) == 2){
						Instantiate(triCoin, new Vector2(Random.Range(clonePos.x - 1.47f, clonePos.x + 9), clonePos.y + 0.2f), Quaternion.identity);
						//baseY -= Random.Range(1.0f, 2.0f);
					}
				}

				if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex >= 5 && spawned < score){
					if(Random.Range(1,3) == 2){
						//clonePos = new Vector3(Random.Range(-4.78f, -0.48f), baseY, 0);
						Instantiate(spikePlatform, new Vector3(clonePos.x, baseY + 0.7f, 0), Quaternion.identity);
						baseY -= Random.Range(1.0f, 2.0f);
						if(spawned < score){
							spawned += 1;
						}
					}
					}

				Debug.Log(spawned);
		}


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
						 if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 7){
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
						 if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 7){
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

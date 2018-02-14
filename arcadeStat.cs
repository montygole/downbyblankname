using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class arcadeStat : MonoBehaviour {
	public int scoreInput;

	bool canFill = false;

	public static float score = 20;

	public static bool isOver = false;

	public AudioSource loseSFX;

	public static float time = 5;

	public static float timeOther = 10;

	public static int startScore = 0;

	public static bool timeRestart = false;

	public GameObject player;

	public Image panel;

	public Text scoreText;

		public Text loseText;
		int i = 0;

	public void gameOver(){
		loseSFX.Play();
		//Debug.Log("GameOver!");
		player.SetActive(false);

		//winObject1.SetActive(true);

		player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
		loseText.gameObject.SetActive(true);
		//menuBtn.transform.position = new Vector2(0, -80);
			//Destroy(panel.gameObject);
			//over = true;

			scoreText.gameObject.SetActive(false);
			isOver = true;
			if(startScore > PlayerPrefs.GetInt("arcadeScore")){
				PlayerPrefs.SetInt("arcadeScore", startScore);
			}
			}

		void regenerate(){
			float toFill = (1 - panel.fillAmount);
			if(panel.fillAmount < 1){
				panel.fillAmount += toFill;
			}
			else if(panel.fillAmount == 1){
				canFill = false;
			}
		}

	void Start(){
		startScore = 0;
		isOver = false;
		statManager.over = false;
		timeRestart = false;
	}
	void Update () {
		Debug.Log("time = " + timeOther);
		if(arcadeCollisions.addScore){
			time += 0.3f;

				startScore++;
				scoreText.text = startScore.ToString();
				arcadeCollisions.addScore = false;
		}
		if(arcadeCollisions.canStart){
		panel.fillAmount -= Time.deltaTime/timeOther;
			scoreText.text = startScore.ToString();
			if(panel.fillAmount <= 0 && i==0){
				gameOver();
				i++;
				//isOver = false;
				return;

			}



			if(timeRestart == true){
				canFill = true;
			 	//timeOther += 1;
			 	panel.fillAmount = 1;
				timeRestart = false;
			}
			if(arcadeCollisions.canStart == false){
				regenerate();
			}

		}


		}


}

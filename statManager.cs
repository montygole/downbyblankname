using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class statManager : MonoBehaviour {
	public int scoreInput;
	public static float score = 20;

	public static float time = 1;

	public float timeOther = 60;

	Text scoreText;

	public GameObject player;

	public Image panel;

  bool can = true;

	int starsNum = 0;

	public AudioSource winSFX;

	public GameObject menuBtn;

	public Button nextBtn;

	public AudioSource loseSFX;

	public GameObject timeThingObject;

	public GameObject winObject1;

	public GameObject winObject2;

	public Image noStar;

	public Image noStar2;

	public Image noStar3;

	public GameObject loseCanv;



	public Text winText;

	bool won = false;

	public static bool over = false;

	public static int startScore;

	//Text timeText;

	Image timeThing;
	// Use this for initialization
	void Start () {
		over = false;
		arcadeStat.isOver = false;
		startScore = scoreInput;
		time = 1;
		startScore = scoreInput;
			winObject1.gameObject.SetActive(false);

				winObject2.gameObject.SetActive(false);
	  scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		// nextBtn = GameObject.Find("nextBtn").GetComponent<Button>();
		// menuBtn = GameObject.Find("menuBtn").GetComponent<GameObject>();

		//timeText = GameObject.Find("TimeText").GetComponent<Text>();


		timeThing = GameObject.Find("Image").GetComponent<Image>();

		//player = GameObject.Find("Circle").GetComponent<gameObject>();
	}

	void checkScore(){

	}

	void stars(){

		//if(over && won){
		if(can){

				//Debug.Log(timeThing.fillAmount * timeOther);
				//Debug.Log(timeOther - timeOther/3);

			 if(timeThing.fillAmount * timeOther >= timeOther- timeOther/1.1f && timeThing.fillAmount * timeOther < timeOther- timeOther/1.5f){
				 if(PlayerPrefs.GetInt("Level" + SceneManager.GetActiveScene().buildIndex + "Stars") < 1){
				 		PlayerPrefs.SetInt("Level" + SceneManager.GetActiveScene().buildIndex + "Stars", 1);
				 }
				//Debug.Log("Yes");
				noStar.color = new Color(0, 0, 0, 255);
				return;
				// one.transform.Translate(GameObject.Find("noStar").GetComponent<GameObject>().transform.position);
			 }
			if(timeThing.fillAmount * timeOther >= timeOther - timeOther/1.5f && timeThing.fillAmount * timeOther < timeOther - timeOther/2){
				if(PlayerPrefs.GetInt("Level" + SceneManager.GetActiveScene().buildIndex + "Stars") < 2){
						PlayerPrefs.SetInt("Level" + SceneManager.GetActiveScene().buildIndex + "Stars", 2);
			  }
				starsNum = 2;
				noStar.color = new Color(0, 0, 0, 255);
				noStar2.color = new Color(0, 0, 0, 255);
				return;

			}
			if(timeThing.fillAmount * timeOther >= timeOther - timeOther/2){
				PlayerPrefs.SetInt("Level" + SceneManager.GetActiveScene().buildIndex + "Stars", 3);
				starsNum = 3;
				noStar.color = new Color(0, 0, 0, 255);
				noStar2.color = new Color(0, 0, 0, 255);
				noStar3.color = new Color(0, 0, 0, 255);
				return;
			}

			can = false;
		}


		//}
	}

	void win(){
		winSFX.Play();
		player.SetActive(false);
		winObject1.gameObject.SetActive(true);

			winObject2.gameObject.SetActive(true);

			over = true;
			scoreText.text = "";

			stars();
			timeThing.gameObject.GetComponent<Animator>().enabled = true;
			won = true;
	}

	public void gameOver(){
		loseSFX.Play();
		//Debug.Log("GameOver!");
		player.SetActive(false);

		winObject1.SetActive(true);

		player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
		loseCanv.gameObject.SetActive(true);
		//menuBtn.transform.position = new Vector2(0, -80);
			Destroy(timeThing.gameObject);
			over = true;

			scoreText.text = "";
			}

	public void restart(){
		//time = 0;
		startScore = scoreInput;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	// Update is called once per frame
	void Update () {
		if(!over){
			time -= Time.deltaTime/timeOther;
		}
		if(over){
			if(timeThing.fillAmount < 1){
				timeThing.fillAmount += 0.05f;
			}
		}
		//timeText.text = tim.ToString();
		if(startScore == 0){
//
				//timeThing.fillAmount = time;
				scoreText.text = score.ToString();
			//Debug.Log("Win!");
			player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
			//player.SetActive(false);
			if(can){
			win();
			can = false;
			//over = false;
			}

		}
		else{
			timeThing.fillAmount = time;
			scoreText.text = startScore.ToString();


		}
		if(timeThing.fillAmount == 0){
			gameOver();
			//over = false;
		}
	}
}

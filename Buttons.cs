using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Buttons : MonoBehaviour {
	AudioSource noiseSound;
	public GameObject overlay;
	public GameObject button1, button2, exitBtn;

	void Start(){
		noiseSound = GameObject.Find("buttonClick").GetComponent<AudioSource>();
	}

	void noise(){
		noiseSound.Play();
	}

	public void next(){
		noise();
		//Debug.Log(SceneManager.GetActiveScene().buildIndex);
		UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void restart(){
		noise();
		//Debug.Log(SceneManager.GetActiveScene().buildIndex);
		UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void menu(){
		noise();
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}

	public void LevelSelect(){
		noise();
		UnityEngine.SceneManagement.SceneManager.LoadScene(int.Parse(this.gameObject.tag));
	}

	public void mainMenu(){
		noise();
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}

	public void arcadeStart(){
		UnityEngine.SceneManagement.SceneManager.LoadScene(10);
	}

	public void gotoLink(){
		Application.OpenURL("https://play.google.com/store/apps/developer?id=blankname&hl=en");
	}
	public void arcadeDrop(){
		noise();
		overlay.gameObject.SetActive(true);
		button1.gameObject.SetActive(true);
		button2.gameObject.SetActive(true);
		exitBtn.gameObject.SetActive(true);
	}
	public void exit(){
			noise();
			overlay.gameObject.SetActive(false);
			button1.gameObject.SetActive(false);
			button2.gameObject.SetActive(false);
			exitBtn.gameObject.SetActive(false);
	}
}

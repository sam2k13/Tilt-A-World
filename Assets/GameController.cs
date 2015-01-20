﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject marble;
	public GameObject scoreController;
	public GameObject gameOverCanvas;
	public GameObject gameCanvas;
	public Text scoreText;
	public Text highScoreText;
	public float endGame = -25.5f;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (marble.transform.position.y < endGame) {
			Time.timeScale = 0;
			gameCanvas.SetActive(false);
			gameOverCanvas.SetActive(true);
			scoreText.text = "Score: " + scoreController.GetComponent<ScoreScript>().getScore();
			highScoreText.text = "High Score: " + scoreController.GetComponent<ScoreScript>().getHighScore();
				
		} 

	}
	public void loadMenu(){
		Time.timeScale = 1;
		Application.LoadLevel (0);
	}
	public void playAgain(){

		Application.LoadLevel (1);
	}
	public void rateMe(){
		return;

	}
	public void showLeaderboard(){
		GooglePlayController.googlePlay.ShowLeaderboard ();
	}
	public void StopScoring(){
		scoreController.GetComponent<ScoreScript>().deactivateScoring();

	}

}

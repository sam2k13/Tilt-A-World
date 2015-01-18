using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public GameObject marble;
	private int score;
	public Text scoreBoard;
	private int velocity;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score = (int)(marble.gameObject.transform.position.z + 5.8f);
		velocity = (int)marble.gameObject.rigidbody.velocity.z;
		scoreBoard.text = score.ToString () + " m";
	}
}

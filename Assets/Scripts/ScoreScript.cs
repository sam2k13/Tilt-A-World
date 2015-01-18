using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public GameObject marble;
	private int score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score = (int)marble.gameObject.transform.position.z;
		Debug.Log (score);
	}
}

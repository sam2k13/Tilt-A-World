using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {
	//public float tiltAngle;
	public float tiltSpeed;
	public Image playButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		playButton.rectTransform.Rotate (new Vector3 (0, 0, tiltSpeed * Time.deltaTime));
	
	}
	public void loadGame(){
		Application.LoadLevel (1);


	}
}

using UnityEngine;
using System.Collections;

public class MarbleController : MonoBehaviour {
	public float maxSpeed;
	public float initialSpeed;
	private float currentSpeed;
	public float sideForce;
	// Use this for initialization
	void Start () {
		currentSpeed = initialSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentSpeed < maxSpeed) {
			//currentSpeed += .1f * Time.deltaTime;		
			rigidbody.AddForce(new Vector3(0,0,currentSpeed));
		} 
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody.AddForce(new Vector3(-sideForce,0,0));		
			
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody.AddForce(new Vector3(sideForce,0,0));		
			
		}
	
	}
}

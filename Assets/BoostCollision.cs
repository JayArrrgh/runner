using UnityEngine;
using System.Collections;

public class BoostCollision : MonoBehaviour {
	
	public float initialBoostForce = 10000f;
	public float boostForcePerSecond = 10000f;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		
		renderer.material.color = Color.blue;
		if (other.gameObject.tag == "Player") {
			
			other.gameObject.SendMessage ("Boost", initialBoostForce);
		}
	}
	
	void OnTriggerStay(Collider other) {
		
		if (other.gameObject.tag == "Player") {
			
			other.gameObject.SendMessage ("Boost", boostForcePerSecond * Time.deltaTime);
		}
	}
}

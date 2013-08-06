using UnityEngine;
using System.Collections;

public class Expire : MonoBehaviour {
	
	float timeToExpire = 10f;
	float timeAlive = 0f;
	Vector3 lastPosition;
	float minVelocity = 3f;
	float minTimeAlive = 5f;
		
	// Use this for initialization
	void Start () {
		lastPosition = transform.position;
		
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//if it stops moving
		Vector3 changeInPosition = (transform.position - lastPosition);
		float velocity = changeInPosition.magnitude * Time.deltaTime;
		
		if (velocity < minVelocity && timeAlive > minTimeAlive)
			Die();
		
		lastPosition = transform.position;
		
	}
	void Update () {
		
		// If it's been around a while
		timeAlive += Time.deltaTime;
		
		if (timeAlive > timeToExpire)
			Die ();
		
		// If it falls off the floor
		if (transform.position.y < 0)
			Die ();
	}
	
	//Dead
	void Die () {
		Destroy (gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class VelocityManager : MonoBehaviour {
	
	public float baseVelocity = 500f;
	
	// Use this for initialization
	void Start () {
		
		rigidbody.AddForce (Vector3.forward * baseVelocity);
		
		//rigidbody.velocity = Vector3.forward * baseVelocity;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (Time.timeSinceLevelLoad + " - forward velocity at " + rigidbody.velocity.x + ".");
	}
}

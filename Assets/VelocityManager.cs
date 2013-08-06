using UnityEngine;
using System.Collections;

public class VelocityManager : MonoBehaviour {
	
	public float baseForce = 5000f;
	public float maxVelocity = 500f;
	float velocityCheckInterval = 0.25f;
	public float startForceDelay;
	float timeSinceLastCheck;
	bool boosted;
	Vector3 fwd;
	public GameObject cameraManager;
	
	
	// Use this for initialization
	void Start () {

		boosted = false;
		fwd = new Vector3(0,0,1);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		timeSinceLastCheck += Time.deltaTime;
		if (!boosted && Time.timeSinceLevelLoad > startForceDelay) {
			Boost (baseForce);
			boosted = true;
			timeSinceLastCheck = 0;
			print ("boost activated");
		}
		
		if (boosted && timeSinceLastCheck > velocityCheckInterval) {
			print (Time.timeSinceLevelLoad + ": forward velocity at " + rigidbody.velocity.z + ".");
			timeSinceLastCheck = 0;
		}
		
		print("velocity: " + rigidbody.velocity.z);
		cameraManager.SendMessage ("ScaleTo", rigidbody.velocity.z / maxVelocity);
	}
	
	void Boost (float force) {
		rigidbody.AddForce (fwd * force);
	}
}

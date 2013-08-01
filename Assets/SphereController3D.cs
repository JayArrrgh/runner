using UnityEngine;
using System.Collections;

public class SphereController3D : MonoBehaviour {
	
	
	public float torqueMultiplier = 5f;

	// Use this for initialization
	void Start () {
		//rigidbody.AddForce(Vector3.forward * baseVelocity);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		float xAxis = Input.GetAxis ("Horizontal");
		
		transform.Translate (xAxis * Time.deltaTime * 2, 0, 0);
		
		/*
		float xAxisCurved = Mathf.Pow(xAxis, 1f / 9f);
		float xTorque = xAxisCurved * torqueMultiplier * -1;
		rigidbody.AddTorque (0, 0, xTorque);
		*/
	}
}

using UnityEngine;
using System.Collections;

public class SphereController3D : MonoBehaviour {
	
	float hMoveSensitivity = 5f;
	public Transform trackBoundary;
	float centerX, widthX;
	
	// Use this for initialization
	void Start () {
		centerX = trackBoundary.position.x;
		widthX = trackBoundary.localScale.x;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float xChange = Input.GetAxis ("Horizontal") * Time.deltaTime * hMoveSensitivity;
		
		float newXPos = transform.position.x + xChange;
		//print ("Center: " + centerX + ". New X position: " + newXPos);
		
		//transform.Translate (xChange, 0, 0);
		Vector3 destination = new Vector3(transform.position.x + xChange, transform.position.y, transform.position.z);
			
		rigidbody.MovePosition (destination);
		ConstrainX ();
		
		/*if (Mathf.Abs (transform.position.x - centerX) < 10) {
			//print ("Absolute value of change: " + Mathf.Abs (newXPos - centerX));
			transform.Translate (trans, 0, 0);
		}*/
		/*
		if (transform.position.x > centerX + 10)
			transform.position.x = centerX + 10;
		else if (transform.position.x < centerX - 10)
			transform.position.x = centerX - 10;
		 */
	}
	
	void ConstrainX () {
	
		//rigidbody.velocity = new Vector3(0, 0, rigidbody.velocity.magnitude);
		if (transform.position.x > centerX + 10)
			rigidbody.MovePosition(new Vector3(centerX + 10, transform.position.y, transform.position.z));
			//transform.Translate((centerX + 10) - transform.position.x, 0, 0);
		if (transform.position.x < centerX - 10)
			rigidbody.MovePosition(new Vector3(centerX - 10, transform.position.y, transform.position.z));
		
		
		
	}
}

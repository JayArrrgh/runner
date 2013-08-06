using UnityEngine;
using System.Collections;

public class CollectibleRotate : MonoBehaviour {
	
	public float xRotationSpeed = 1.0f;
	public float yRotationSpeed = 1.0f;
	public float zRotationSpeed = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate () {
		
		Vector3 rotateTo;
		rotateTo.x = xRotationSpeed;
		rotateTo.y = yRotationSpeed;
		rotateTo.z = zRotationSpeed;
		
		transform.Rotate(rotateTo);
		
	}
}

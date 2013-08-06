using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	
	public float jumpForce = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump")) {
			//rigidbody.AddForce(0, jumpForce, 0);
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpForce, rigidbody.velocity.z);	
			
		}
	}
}

using UnityEngine;
using System.Collections;

public class BasicStrafe : MonoBehaviour {
	
	public float moveSpeed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float hor = Input.GetAxis ("Horizontal");
		transform.Translate(hor * moveSpeed, 0, 0);
		
		
	}
}

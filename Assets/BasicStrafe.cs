using UnityEngine;
using System.Collections;

public class BasicStrafe : MonoBehaviour {
	
	public float moveSpeed;
	public GameObject spawnPoint;
	public float horizontalRange;
	float centerX;
	
	// Use this for initialization
	void Start () {
		centerX = spawnPoint.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		
		float hor = Input.GetAxis ("Horizontal");
		
		float newX = transform.position.x + hor * moveSpeed;
		
		if (newX < centerX + horizontalRange && newX > centerX - horizontalRange)
			transform.Translate(hor * moveSpeed, 0, 0);
		
	}
	
	void FixedUpdate() {
	
		if (transform.position.x > centerX + horizontalRange) {
			transform.Translate ((centerX + horizontalRange) - transform.position.x, 0, 0);
		}
		if (transform.position.x < centerX - horizontalRange) {
			transform.Translate ((centerX - horizontalRange) - transform.position.x, 0, 0);
		}
		
	}
}

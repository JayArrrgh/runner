using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject target;
	public float zOffset = -50f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.transform.position = new Vector3(
			gameObject.transform.position.x,
			gameObject.transform.position.y,
			target.transform.position.z + zOffset);
		
	}
}

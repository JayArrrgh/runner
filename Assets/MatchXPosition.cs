using UnityEngine;
using System.Collections;

public class MatchXPosition : MonoBehaviour {
	public GameObject target;
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.transform.position = new Vector3(target.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		
	}
}

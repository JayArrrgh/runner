using UnityEngine;
using System.Collections;

public class MatchPosition : MonoBehaviour {
	public GameObject target;
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = target.transform.position;
	
		
		
	}
}

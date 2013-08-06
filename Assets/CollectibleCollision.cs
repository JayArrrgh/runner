using UnityEngine;
using System.Collections;

public class CollectibleCollision : MonoBehaviour {

	public float energyValue = 1.0f;
	public float boostForce = 100f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		
		
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage ("Boost", boostForce);
			GameObject.Destroy(gameObject);
		}
	}
}

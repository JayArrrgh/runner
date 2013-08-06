using UnityEngine;
using System.Collections;

public class ScaleFOV : MonoBehaviour {
	
	public int baseFieldOfView = 60;
	public int maxFieldOfView = 100;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void ScaleTo (float percentage) {
		
		Camera cam = transform.FindChild("Camera3D").camera;
		cam.fieldOfView = Mathf.Lerp (baseFieldOfView, maxFieldOfView, percentage);
	}
}

using UnityEngine;
using System.Collections;

public class SwitchCameras : MonoBehaviour {
	
	public Camera Camera1;
	public Camera Camera2;
	
	// Use this for initialization
	void Start () {
		Camera1.enabled = false;
		Camera2.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			ToggleCameras ();
		}
		
		
	}
	
	void ToggleCameras () {
		Camera1.enabled = !Camera1.enabled;
		Camera2.enabled = !Camera2.enabled;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

	public GameObject LightObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnGUI () {

		if (LightObject.GetComponent<Light> ().enabled) {
			if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Turn Off")) {
				Debug.Log ("Hello World" + Time.time);
				LightObject.GetComponent<Light> ().enabled = false;

			}
		} else {
			if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Turn On")) {
				Debug.Log ("Hello World" + Time.time);
				LightObject.GetComponent<Light> ().enabled = true;

			}
		}


	}
}

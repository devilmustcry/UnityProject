using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	private int random;
	// Use this for initialization
	void Start () {
		random = Random.Range (0, 5);
		switch (random) {
		case 0:
			GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.green);
			break;
		case 1:
			GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.blue);
			break;
		case 2:
			GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.red);
			break;
		case 3:
			GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.magenta);
			break;
		case 4:
			GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.black);
			break;
		
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.up * Time.deltaTime*10f);
		if (this.gameObject.transform.position.y >= 20f) {
			Destroy (this.gameObject);
		}
	
	}

	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
		Destroy (this.gameObject);

	}
		
}

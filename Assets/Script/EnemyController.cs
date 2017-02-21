using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (1, 10);
	}

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * speed);
		if (this.gameObject.transform.position.y <= -20f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter (Collider other) {
		Destroy (other.gameObject);
	}
}

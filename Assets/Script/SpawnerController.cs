using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

	private int spawnTime;
	private int lastSpawn;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		this.spawnTime = Random.Range (1, 5);
		lastSpawn = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 screenEdge = Camera.main.WorldToViewportPoint (transform.position);


		if (Time.time - lastSpawn >= spawnTime) {
			lastSpawn = (int) Mathf.Floor (Time.time);
			Instantiate (enemy, this.gameObject.transform.position, Quaternion.identity);
			this.spawnTime = Random.Range (1, 5);

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {

	public GameObject myBullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 screenEdge = Camera.main.WorldToViewportPoint (transform.position);

	
		if (Input.GetAxis("Horizontal")!=0) {
			if (!(screenEdge.x < 0.0 || screenEdge.x > 1.0) || (screenEdge.x < 0.0 && Input.GetAxis("Horizontal")>0) || (screenEdge.x > 1.0 && Input.GetAxis("Horizontal")<0))
				gameObject.transform.Translate (Input.GetAxis("Horizontal")*Vector3.right*Time.deltaTime *5f);

			
		} else if (Input.GetAxis("Vertical")!=0) { 
			if (!(screenEdge.y < 0.0 || screenEdge.y > 1.0) || (screenEdge.y < 0.0 && Input.GetAxis("Vertical")>0) || (screenEdge.y > 1.0 && Input.GetAxis("Vertical")<0))
				gameObject.transform.Translate (Input.GetAxis("Vertical")*Vector3.up*Time.deltaTime*5f);
		} else if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (myBullet, this.gameObject.transform.position , Quaternion.identity);
		}
	}
}

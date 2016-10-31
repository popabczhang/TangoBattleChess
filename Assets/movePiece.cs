
using UnityEngine;
using System.Collections;

public class movePiece : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (gameObject.CompareTag ("cube") || gameObject.CompareTag ("cube1")) {
			gameObject.GetComponent<Renderer> ().material.color = new Color (255, 0, 0, 250);
		}
	}
}

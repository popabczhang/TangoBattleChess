using UnityEngine;
using System.Collections;



public class changecolor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("cube") || other.gameObject.CompareTag ("cube1")) {
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (255, 0, 0, 250);
		}
	} 

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("cube")) {
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (255, 255, 255, 250);
		} 
		if (other.gameObject.CompareTag ("cube1")){
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (0, 0, 0, 250);
		}
	}
}

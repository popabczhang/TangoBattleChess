using UnityEngine;
using System.Collections;

public class takeMe : MonoBehaviour {

	private Transform taker = null;
	private float x,y,z;
	public bool picked = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		// Logic to pick up enable and disable - coming from the UI
		if (Input.touchCount > 0){

//		if(Input.GetKeyDown("t")) {
//			Debug.Log ("Key down");
//		Take only x and z co ordinate from the parent. This seems more plausible
			transform.parent = taker;
		}
		
		// makes the rotation locked even if the picker rotation changes
		//transform.rotation = Quaternion.identity;
//		transform.Rotate(Vector3.up * rotation);
//		transform.rotation = Quaternion.Euler(-89.981f, 0.0f, 0.0f);
//		} else if(Input.GetKeyDown("g")) {
//			transform.parent = null;
//
//		}

	}

	void OnTriggerEnter (Collider col) {
		

			if(col.CompareTag("Player")) {
				picked = true;
				Debug.Log ("Theres contact!!!");
	//			x = col.transform.position.x;
	//			y = transform.position.y;
	//			z = col.transform.position.z;
				taker = col.transform;
	//			taker.transform.position = new Vector3(x,y,z);
			}
		

	}    

	void OnTriggerExit (Collider col) {

		if(col.CompareTag("Player")) {
			taker = null;
		}

	}
}
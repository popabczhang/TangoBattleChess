using UnityEngine;
using System.Collections;

public class takeMe : MonoBehaviour {

	private Transform taker = null;
	private Component hitCol = null;
	private bool tempTouch = false;
	private bool entered = false;
	private float x,y,z;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
		if(entered){

		// Logic to pick up enable and disable - coming from the UI
			if (hitCol.GetComponent<networkedTouchBool>().networkTouch) {
				hitCol.GetComponent<networkedTouchBool> ().isCarrying = true;
//		if(Input.GetKeyDown("t")) {
//			Debug.Log ("Key down");
//		Take only x and z co ordinate from the parent. This seems more plausible
			transform.parent = taker;
			
		} else {
			transform.parent = null;
			hitCol.GetComponent<networkedTouchBool> ().isCarrying = false;
//			picked = false;
		}
		
		// makes the rotation locked even if the picker rotation changes
		//transform.rotation = Quaternion.identity;
//		transform.Rotate(Vector3.up * rotation);
//		transform.rotation = Quaternion.Euler(-89.981f, 0.0f, 0.0f);
//		} else if(Input.GetKeyDown("g")) {
//			transform.parent = null;
//
//		}

//		if (picked == true && Input.touchCount>0) {
//			
//			Debug.Log ("piked up!");
//			x = taker.position.x;
//			y = transform.position.y;
//			z = taker.position.z;
//			transform.position = new Vector3 (x, y, z);
//
//		}
		}

	}

	void OnTriggerEnter (Collider col) {
		

		if(col.CompareTag("Player") && col.GetComponent<networkedTouchBool>().isCarrying == false) {
				
				entered = true;
			
//				Debug.Log ("Theres contact!!!");
	//			x = col.transform.position.x;
	//			y = transform.position.y;
	//			z = col.transform.position.z;
				taker = col.transform;
				hitCol = col.GetComponent<networkedTouchBool>();
//				col.GetComponent<networkedTouchBool> ().isCarrying = true;
	//			taker.transform.position = new Vector3(x,y,z);
			}
		

	}    

	void OnTriggerExit (Collider col) {

		if(col.CompareTag("Player")) {
//			taker = null;
			entered = false;
		}

	}
}
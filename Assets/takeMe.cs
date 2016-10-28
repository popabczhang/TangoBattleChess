using UnityEngine;
using System.Collections;

public class takeMe : MonoBehaviour {

	private Transform taker;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		// Logic to pick up enable and disable - coming from the UI


//		if(Input.GetKeyDown("t")) {
//			Debug.Log ("Key down");
//		Take only x and z co ordinate from the parent. This seems more plausible
			transform.parent = taker;
		// makes the rotation locked even if the picker rotation changes
		//transform.rotation = Quaternion.identity;

//		} else if(Input.GetKeyDown("g")) {
//			transform.parent = null;
//
//		}

	}

	void OnTriggerEnter (Collider col) {

		if(col.CompareTag("Player")) {

			Debug.Log ("Theres contact!!!");

			taker = col.transform;

		}

	}    

	void OnTriggerExit (Collider col) {

		if(col.CompareTag("Player")) {
			taker = null;
		}

	}
}
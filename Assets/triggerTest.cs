using UnityEngine;
using System.Collections;

public class triggerTest : MonoBehaviour {
	void Start() {
		//		otherScript.DoSomething();
	}

	void OnTriggerEnter ( Collider other ){
		Component halo = GetComponent("Halo");
		halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
		gameObject.GetComponent<ParticleSystem>().Play();
		Debug.Log ("JetPack picked!");
		//		GameObject vrMove = GameObject.Find ("CardboardMain");
		//		VRMoveController vrMoveLoc = vrMove.GetComponent<VRMoveController>();
		//		vrMoveLoc.hangTime();
		//		Destroy(this.gameObject);
	}
}
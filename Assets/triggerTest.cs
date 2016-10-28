using UnityEngine;
using System.Collections;

public class triggerTest : MonoBehaviour {
	void Start() {
		//		otherScript.DoSomething();
	}

	void OnTriggerEnter ( Collider other ){
		
		//Component halo = GetComponent("Halo");
//		halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
		if (GetComponent<ParticleSystem> ().isPlaying) {
			GetComponent<ParticleSystem> ().Stop ();
		} else {
			GetComponent<ParticleSystem> ().Play ();
		}

//		gameObject.GetComponent<ParticleSystem>().Play();
		Debug.Log ("JetPack picked!");

//		ExitGames.Client.Photon.Hashtable<string, bool> property = new 
//		PhotonNetwork.room.SetCustomProperties();
//		r.SetCustomProperties();
	}
}
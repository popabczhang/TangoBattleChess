using UnityEngine;
using System.Collections;


public class animation : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("1")){
			anim.Play ("WK_heavy_infantry_08_attack_B",-1,0f);
		}
	}

//	void onTriggerEnter (Collider other){
//		if (other.gameObject.CompareTag ("Player")) {
//			anim.Play ("WK_heavy_infantry_08_attack_B", -1, 0f);
//		}
//	}
}

using UnityEngine;
using System.Collections;



public class changecolor : MonoBehaviour {

	public GameObject Btn; 
	private bool BtnBool = false;
	private float t = 0;
    public GameObject[] Cells;
    public GameObject[] PiecesPlayer1;
    public GameObject[] PiecesPlayer2;

    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	void Update () {
		Btn.SetActive (BtnBool);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("cube") || other.gameObject.CompareTag ("cube1")) {
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (255, 0, 0, 250);
		}
		t = 0;
	} 

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("cube")) {
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (255, 255, 255, 250);
		} 
		if (other.gameObject.CompareTag ("cube1")){
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (0, 0, 0, 250);
		}
		BtnBool = false;
	}
		
	void OnTriggerStay(Collider other){
		t += Time.deltaTime;
		if (t > 3 && other.gameObject.CompareTag("Bishop")){
			BtnBool = true;
		} 
	}

}

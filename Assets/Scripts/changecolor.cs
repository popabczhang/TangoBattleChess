using UnityEngine;
using System.Collections;



public class changecolor : MonoBehaviour {

    public GameObject[] Cells;
    public GameObject[] PiecesPlayer1;
    public GameObject[] PiecesPlayer2;

    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player") ) {
			 gameObject.GetComponent<Renderer> ().material.color = new Color (255, 0, 0, 250);
		}
	} 

	void OnTriggerExit(Collider other) {
		if ( gameObject.CompareTag ("cube"))  {
			 gameObject.GetComponent<Renderer> ().material.color = new Color (255, 255, 255, 250);
		} 
		if (gameObject.CompareTag ("cube1")){
			 gameObject.GetComponent<Renderer> ().material.color = new Color (0, 0, 0, 250);
		}
	}
}

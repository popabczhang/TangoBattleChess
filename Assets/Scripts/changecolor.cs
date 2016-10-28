using UnityEngine;
using System.Collections;



public class changecolor : MonoBehaviour {

    public GameObject[] Cells;
    public GameObject[] PiecesPlayer1;
    public GameObject[] PiecesPlayer2;

    private int x, y, i, j, n;
    private Vector3 pos;


    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("cube") || other.gameObject.CompareTag ("cube1")) {
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (255, 0, 0, 250);

            pos = other.gameObject.transform.localPosition;
            x = Mathf.RoundToInt(pos.x + 1);
            y = Mathf.RoundToInt(pos.z);
            Debug.Log("x = " + x + "; y = " + y);

            n = y * 8 + x;
            for (i = y + 1; i <= 7; i++)
            {
                if (x - i >= 0)
                {
                    Cells[8 * i - (i-y)].GetComponent<Renderer>().material.color = new Color(0, 255, 0, 255);
                }
                if (x + i <= 7)
                {
                    Cells[8 * i + (i-y)].GetComponent<Renderer>().material.color = new Color(0, 255, 0, 255);
                }
            }
        }
        

    } 

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("cube")) {
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (255, 255, 255, 250);
		} 
		if (other.gameObject.CompareTag ("cube1")){
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (0, 0, 0, 250);
		}


        pos = other.gameObject.transform.localPosition;
        x = Mathf.RoundToInt(pos.x + 1);
        y = Mathf.RoundToInt(pos.z);
        Debug.Log("x = " + x + "; y = " + y);

        n = y * 8 + x;
        for (i = y + 1; i <= 7; i++)
        {
            if (x - i >= 0)
            {
                if (Cells[8 * i - (i - y)].CompareTag("cube"))
                {
                    Cells[8 * i - (i - y)].GetComponent<Renderer>().material.color = new Color(255, 255, 255, 250);
                }
            }
            if (x + i <= 7)
            {
                if (Cells[8 * i + (i - y)].CompareTag("cube1"))
                {
                    Cells[8 * i + (i - y)].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 250);
                }

            }
        }
    }
}

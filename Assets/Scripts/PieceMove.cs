using UnityEngine;
using System.Collections;

public class PieceMove : MonoBehaviour {

    public bool pickedUp = false;
    public Transform pickingTransform;
    public float x, y, z;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (pickedUp == true)
        {
            Debug.Log("picked up!");
            x = pickingTransform.position.x;
            y = transform.position.y;
            z = pickingTransform.position.z;
            Debug.Log("x = " + x + "; y = " + y + "; z = " + z);
            transform.position = new Vector3(x, y, z);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 250);
            pickedUp = true;
            pickingTransform = other.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {

    }
}

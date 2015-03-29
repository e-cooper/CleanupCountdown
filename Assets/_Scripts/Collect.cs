using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Destroy (gameObject);
		}
	}
}

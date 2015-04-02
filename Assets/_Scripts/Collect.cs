using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	GameObject gameController;

	// Use this for initialization
	void Start () {
		gameController = GameObject.FindGameObjectWithTag ("GameController");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			gameController.GetComponent<GameController> ().IncrementScore ();
			Destroy (gameObject);
		}
	}
}

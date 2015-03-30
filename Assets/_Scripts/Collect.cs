using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	public GameObject gameController;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Destroy (gameObject);
		}
	}

	void OnDestroy() {
		gameController = GameObject.FindWithTag ("GameController");
		gameController.GetComponent<GameController> ().IncrementScore ();
	}
}

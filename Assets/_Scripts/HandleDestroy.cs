using UnityEngine;
using System.Collections;

public class HandleDestroy : MonoBehaviour {

	private bool isQuitting = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnApplicationQuit() {
		isQuitting = true;
	}

	void OnDestroy() {
		if (!isQuitting) {
			GameObject.FindGameObjectWithTag ("GameController")
				.GetComponent<Replace> ().ReplaceObject (gameObject);
		}
	}
}

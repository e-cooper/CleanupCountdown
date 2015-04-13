using UnityEngine;
using System.Collections;

public class HandleDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy() {
		GameObject.FindGameObjectWithTag("GameController").GetComponent<Replace>().ReplaceObject(gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class Replace : MonoBehaviour {

	public GameObject neatBed;
	public GameObject neatPapers;
	public GameObject neatBooks;
	public GameObject neatDrawers;
	public GameObject neatRug;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ReplaceObject(GameObject destroyedObj) {
		Vector3 spawnPos = destroyedObj.transform.position;
		Quaternion spawnRotation = destroyedObj.transform.rotation;
		GameObject replacement;

		if (destroyedObj.tag == "MessyBed") {
			replacement = Instantiate (neatBed, spawnPos, spawnRotation) as GameObject;
		} else if (destroyedObj.tag == "MessyPapers") {
			replacement = Instantiate (neatPapers, spawnPos, spawnRotation) as GameObject;
		} else if (destroyedObj.tag == "MessyBooks") {
			replacement = Instantiate (neatBooks, spawnPos, spawnRotation) as GameObject;
		} else if (destroyedObj.tag == "MessyDrawers") {
			replacement = Instantiate (neatDrawers, spawnPos, spawnRotation) as GameObject;
		} else if (destroyedObj.tag == "MessyRug") {
			replacement = Instantiate (neatRug, spawnPos, spawnRotation) as GameObject;
		}
	}
}

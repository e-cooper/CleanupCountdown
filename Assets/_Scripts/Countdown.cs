using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

	private float time;
	public GUIText timer;

	// Use this for initialization
	void Start () {
		time = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		time = Time.deltaTime;
		timer.text = "Time: " + time;
	}
}

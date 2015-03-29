using UnityEngine;
using System.Collections;

public class ClickController : MonoBehaviour {

	Vector3 target;
	float speed = 1.0f;

	// Use this for initialization
	void Start () {
		target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				target = hit.point;
			}
		}
		transform.position = Vector3.Lerp (transform.position, target, speed * Time.deltaTime);
	}
}
using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

	public Texture2D crosshairTexture;
	public int distance;
	public LayerMask layerMask;

	private RaycastHit hit;
	private Transform cam;
	private Rect crosshairPos;
	private static bool crosshair;

	// Use this for initialization
	void Start () {
		cam = Camera.main.transform;
		crosshair = true;		
	}
	
	// Update is called once per frame
	void Update () {
		crosshairPos = new Rect ((Screen.width - crosshairTexture.width) / 2,
		                        (Screen.height - crosshairTexture.height) / 2, 
		                        crosshairTexture.width, crosshairTexture.height);
		if (Input.GetMouseButtonDown (0) && Physics.Raycast (cam.position, cam.forward, out hit, distance, layerMask)) {
			if (hit.collider.gameObject.tag == "Pickup") {
				hit.collider.gameObject.GetComponent<Collect>().CollectItem();
			}
		}
	}

	private void OnGUI() {
		if (crosshair = true) {
			GUI.DrawTexture(crosshairPos, crosshairTexture);
		}
	}
}

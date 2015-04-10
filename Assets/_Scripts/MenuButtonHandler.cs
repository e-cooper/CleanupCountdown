using UnityEngine;
using System.Collections;

public class MenuButtonHandler : MonoBehaviour {

	void Start() {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void StartLevel() {
		Application.LoadLevel ("mainScene");
	}
	
	public void ExitGame() {
		Application.Quit ();
	}
}

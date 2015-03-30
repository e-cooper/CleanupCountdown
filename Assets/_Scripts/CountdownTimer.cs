using UnityEngine;
using System.Collections;

public class CountdownTimer : MonoBehaviour {

	public float time;
	public UnityEngine.UI.Text counterText;
	
	void Update () {
		
		time -= Time.deltaTime;
		
		int minutes = (int) time / 60;
		int seconds = (int) time % 60;
		float fraction = Mathf.Round((time * 100) % 100);
		
		if (time > 0) {
			counterText.text = minutes + ":" + seconds + ":" + fraction;
		} else {
			gameObject.GetComponent<GameController>().GameOver(false);
		}
		
	}
	
	public float GetTime() {
		return time;
	}
}

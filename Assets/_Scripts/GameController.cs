using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public UnityEngine.UI.Text gameOverText, scoreText;
	public float resetDelay;
	public int goalScore;

	private int score;
	private float resetTimer;
	private bool gameOver, win;

	void Start () {
		Time.timeScale = 1;
		gameOver = false;
		// Lock cursor in place unless Esc is pressed
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update () {
		if (gameOver) {
			GameOverDisplay ();
			Reset ();
		}
	}

	public void IncrementScore() {
		score += 1;
		if (score >= goalScore) {
			GameOver (true);
		}
	}

	public void GameOver (bool endState) {
		gameOver = true;
		win = endState;
		Time.timeScale = 0;
	}
	
	private void GameOverDisplay () {
		if (win) {
			gameOverText.text = "You win!";
			scoreText.text = "Score: " + score;
		} else {
			gameOverText.text = "You lose...";
		}
	}
	
	private void Reset () {
		resetTimer += Time.unscaledDeltaTime;
		if (resetTimer >= resetDelay) {
			Application.LoadLevel (0);
		}
	}
}

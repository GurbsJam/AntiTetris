using UnityEngine;
using System.Collections;

public class Tetromino : MonoBehaviour {

	private GameController gameController;
	private Spawner spawner;
	private int health;
	private float gameOverCountdown;

	public void SetGameController(GameController gameController) {
		this.gameController = gameController;
	}

	public void SetSpawner(Spawner spawner) {
		this.spawner = spawner;
	}

	public void SetHealth(int health) {
		this.health = health;
	}

	void OnMouseDown () {
		health -= 1;

		if (health <= 0) {
			gameObject.SetActive(false);
			spawner.RecycleObject(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject == gameController.upperBoundary) {
			gameOverCountdown = 0;
		}
	}

	void OnTriggerStay2D (Collider2D collider) {
		if (collider.gameObject == gameController.upperBoundary) {
			gameOverCountdown += Time.deltaTime;
			if (gameOverCountdown >= gameController.gameOverThreshold) {
				gameController.GameOver();	
			}
		}
	}

	void OnTriggerExit2D (Collider2D collider) {
		if (collider.gameObject == gameController.upperBoundary) {
			gameOverCountdown = 0;
		}
	}

}

using UnityEngine;
using System.Collections;

public class Tetromino : MonoBehaviour {

	private const float STATE_1_MIN_HEALTH = 0.6f;
	private const float STATE_2_MIN_HEALTH = 0.3f;

	[Header("Sprites")]
	public Sprite state1Sprite;
	public Sprite state2Sprite;
	public Sprite state3Sprite;

	private GameController gameController;
	private Spawner spawner;
	private int health;
	private int fullHealth;
	private float gameOverCountdown;

	public void Reset(GameController gameController, Spawner spawner, int fullHealth) {
		this.gameController = gameController;
		this.spawner = spawner;
		this.health = fullHealth;
		this.fullHealth = fullHealth;

		UpdateSprite();
	}

	public void DoDamage(int damage) {
		health -= damage;

		if (health <= 0) {
			gameObject.SetActive(false);
			spawner.RecycleObject(gameObject);
			gameController.resourceController.incrementBlocksDestroyed();
		} else {
			UpdateSprite();
		}
	}

	private void UpdateSprite() {
		float healthPercentage = ((float) health) / fullHealth;
		if (healthPercentage >= STATE_1_MIN_HEALTH) {
			gameObject.GetComponent<SpriteRenderer>().sprite = state1Sprite;
		} else if (healthPercentage >= STATE_2_MIN_HEALTH) {
			gameObject.GetComponent<SpriteRenderer>().sprite = state2Sprite;
		} else {
			gameObject.GetComponent<SpriteRenderer>().sprite = state3Sprite;
		}
	}

	void OnMouseDown () {
		DoDamage(gameController.resourceController.getDamage());
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject == gameController.upperBoundary) {
			gameOverCountdown = 0;
		}
	}

	void OnTriggerStay2D (Collider2D collider) {
		if (collider.gameObject == gameController.upperBoundary) {
			gameOverCountdown += Time.deltaTime;
			if (gameOverCountdown >= gameController.resourceController.gameOverThreshold) {
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

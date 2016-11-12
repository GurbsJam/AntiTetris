using UnityEngine;
using System.Collections;

public class Tetromino : MonoBehaviour {

	private Spawner spawner;
	private int health;

	void OnMouseDown () {
		health -= 1;

		if (health <= 0) {
			gameObject.SetActive(false);
			spawner.RecycleObject(gameObject);
		}
	}

	public void SetSpawner(Spawner spawner) {
		this.spawner = spawner;
	}

	public void SetHealth(int health) {
		this.health = health;
	}

}

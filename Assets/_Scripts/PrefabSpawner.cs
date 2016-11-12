using UnityEngine;
using System.Collections;

public class PrefabSpawner : Spawner {

	public GameObject prefab;
	
	override public GameObject CreateGameObject() {
		return (GameObject) Instantiate(prefab);
	}

	override public void BindGameObject(GameObject gameObject, int position) {
		Tetromino tetromino = gameObject.GetComponent<Tetromino>();
		tetromino.SetSpawner(this);
		tetromino.SetHealth(1);

		gameObject.transform.position = Vector3.zero;
		gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		gameObject.SetActive(true);
	}

}

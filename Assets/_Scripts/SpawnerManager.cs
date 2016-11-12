using UnityEngine;
using System.Collections;

public class SpawnerManager : MonoBehaviour {

	public Spawner[] spawners;

	private Vector3 rotation;

	void Start () {
		rotation = new Vector3();

		InvokeRepeating("Spawn", 0, 2);
	}

	void Spawn () {
		Spawner spawner = spawners[Random.Range(0, spawners.Length)];
		GameObject gameObject = spawner.SpawnObject();

		rotation.Set(0, 0, Random.Range(0, 360));
		gameObject.transform.position = transform.position;
		gameObject.transform.Rotate(rotation);
	}
}

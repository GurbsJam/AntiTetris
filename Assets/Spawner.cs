using UnityEngine;
using System.Collections;

public abstract class Spawner : MonoBehaviour {

	private ArrayList liveObjects;
	private ArrayList deadObjects;

	void Start () {
		liveObjects = new ArrayList();
		deadObjects = new ArrayList();
	}

	void Update () {
		for (int i = liveObjects.Count - 1; i >= 0; --i) {
			GameObject gameObject = (GameObject) liveObjects[i];
			if (gameObject.activeSelf) {
				//RecycleObject(gameObject);
			}
		}
	}

	public GameObject SpawnObject () {
		GameObject gameObject;

		if (deadObjects.Count > 0) {
			gameObject = (GameObject) deadObjects[0];
			deadObjects.RemoveAt(0);
		} else {
			gameObject = CreateGameObject();
		}

		BindGameObject(gameObject, liveObjects.Count);
		liveObjects.Add(gameObject);

		return gameObject;
	}

	private void RecycleObject (GameObject gameObject) {
		if (liveObjects.Contains(gameObject)) {
			liveObjects.Remove(gameObject);
			deadObjects.Add(gameObject);
		}
	}

	public abstract GameObject CreateGameObject();
	public abstract void BindGameObject(GameObject gameObject, int position);

}

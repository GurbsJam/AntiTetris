using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public IAdapter adapter;

	private ArrayList liveObjects;
	private ArrayList deadObjects;

	// Use this for initialization
	void Start () {
		liveObjects = new ArrayList();
		deadObjects = new ArrayList();

		InvokeRepeating("SpawnObject", 0, 2);
	}

	// Update is called once per frame
	void Update () {
		for (int i = liveObjects.Count - 1; i >= 0; --i) {
			GameObject gameObject = (GameObject) liveObjects[i];
			Renderer renderer = (Renderer) gameObject.GetComponent(typeof(Renderer));
			if (renderer && !renderer.isVisible) {
				RecycleObject(gameObject);
			}
		}
	}

	private void SpawnObject () {
		GameObject gameObject;

		if (deadObjects.Count > 0) {
			gameObject = (GameObject) deadObjects[0];
			deadObjects.RemoveAt(0);
		} else {
			gameObject = adapter.CreateGameObject();
		}

		adapter.BindGameObject(gameObject, liveObjects.Count);
		liveObjects.Add(gameObject);
	}

	private void RecycleObject (GameObject gameObject) {
		if (liveObjects.Contains(gameObject)) {
			liveObjects.Remove(gameObject);
			deadObjects.Add(gameObject);
		}
	}

	public abstract class IAdapter : MonoBehaviour {

		GameObject CreateGameObject();
		void BindGameObject(GameObject gameObject, int position);

	}

}

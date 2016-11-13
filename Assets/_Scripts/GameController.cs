using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

	public ResourceController resourceController;
	public Spawner[] spawners;

	[Header("Boundaries")]
	public GameObject upperBoundary;
	public GameObject leftBoundary;
	public GameObject rightBoundary;

	private Vector3 position;
	private Vector3 rotation;

	private Collider2D leftBoundaryCollider;
	private Collider2D rightBoundaryCollider;

	void Start () {
		position = new Vector3();
		rotation = new Vector3();

		leftBoundaryCollider = leftBoundary.GetComponent<Collider2D>();
		rightBoundaryCollider = rightBoundary.GetComponent<Collider2D>();

		InvokeRepeating("Spawn", 0, resourceController.spawnInterval);
	}

	void Spawn () {
		Spawner spawner = spawners[Random.Range(0, spawners.Length)];
		GameObject gameObject = spawner.SpawnObject(this);

		rotation.Set(0, 0, Random.Range(0, 360));
		gameObject.transform.Rotate(rotation);

		Collider2D gameObjectCollider = gameObject.GetComponent<Collider2D>();
		float minX = leftBoundary.transform.position.x + leftBoundaryCollider.bounds.extents.x + gameObjectCollider.bounds.extents.x;
		float maxX = rightBoundary.transform.position.x - rightBoundaryCollider.bounds.extents.x - gameObjectCollider.bounds.extents.x;
		position.Set(Random.Range(minX, maxX), spawners[0].transform.position.y, 0);
		gameObject.transform.position = position;
	}

	public void GameOver () {
		print("GAME OVER!");
		Scene loadedLevel = SceneManager.GetActiveScene();
		SceneManager.LoadScene(loadedLevel.buildIndex);
	}

}

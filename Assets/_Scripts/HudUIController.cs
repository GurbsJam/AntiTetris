using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HudUIController : MonoBehaviour {

	public ResourceController resourceController;
	
	// Update is called once per frame
	void Update () {
		string blocksDestroyed = resourceController.getBlocksDestroyed().ToString();
		print("Blocks destroyed: " + blocksDestroyed);

		gameObject.GetComponent<Text>().text = blocksDestroyed;
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HudUIController : MonoBehaviour {

	public ResourceController resourceController;
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text>().text = resourceController.getBlocksDestroyed().ToString();
	}
}

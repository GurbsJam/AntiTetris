using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradeUIController : MonoBehaviour {

	public Text tapDamageTitle;
	public Text tapDamageLevel;
	public Text tapDamagePrice;

	public Text moneyPerBrickTitle;
	public Text moneyPerBrickLevel;
	public Text moneyPerBrickPrice;

	public Text shakeDamageTitle;
	public Text shakeDamageLevel;
	public Text shakeDamagePrice;

	public Text shakeTimeTitle;
	public Text shakeTimeLevel;
	public Text shakeTimePrice;

	// Use this for initialization
	void Start () {
		UpdateUIValues();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateUIValues ()
	{
		tapDamageLevel.text = "Level " + ResourceController.damageUpgradeLevel;
		tapDamagePrice.text = ResourceController.damageUpgradeCostBase.ToString();

		moneyPerBrickLevel.text = "Level " + ResourceController.moneyPerBrickUpgradeLevel;
		//moneyPerBrickPrice.text = ResourceController.moneyPerBrickUpgradePrice;

		shakeDamageLevel.text = "Level " + ResourceController.skill1DamageUpgradeLevel;
		//shakeDamagePrice.text = 

		shakeTimeLevel.text = "Level " + ResourceController.skill1RechargeUpgradeLevel;
		//shakeTimePrice.text =
	}
}

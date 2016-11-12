using UnityEngine;
using System.Collections;

public class ResourceController : MonoBehaviour {

	//Money
	[Header("Money")]
	public int moneyAmount;
	public int moneyPerBrick;
	public int moneyPerBrickUpgradeLevel;
	public int moneyPerBrickUpgrageBase;
	public float moneyPerBrickUpgradeMultiplier;
	public int moneyPerBrickUpgradeCostBase;
	public float moneyPerBrickUpgradeCostMultiplier;
	public int initialMoney;

	//TODO: Leveling up and stuff...
	//public int level;
	//public int xp;
	//public float xpMultiplier;
	//public int xpPerBrick;
	//public int xpPerBrick_upgradeBase;
	//public float xpPerBrick_upgradeMultiplier;
	//... and other variables to get XP Threshold for level up, etc...

	//Damage
	[Header("Damage")]
	public int damageAmount;
	public int damageUpgradeLevel;
	public int damageUpgrageBase;
	public float damageUpgradeMultiplier;
	public int damageUpgradeCostBase;
	public float damageUpgradeCostMultiplier;

	//Skill
	[Header("Skill")]
	public int skill1Damage;
	public int skill1Recharge;

	void addMoney ()
	{
		moneyAmount += moneyPerBrick;
	}

	//TODO: Add XP
	//void addXP
	//{
	//	xxx
	//}





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

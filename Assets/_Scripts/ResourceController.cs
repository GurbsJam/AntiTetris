using UnityEngine;
using System.Collections;

public class ResourceController : MonoBehaviour {

	//Money
	[Header("Money")]
	public static int moneyAmount;
	public static int initialMoney;

	public static int moneyPerBrickUpgradeLevel;
	public static int moneyPerBrickUpgrageBase;
	public static float moneyPerBrickUpgradeMultiplier;
	public static int moneyPerBrickUpgradeCostBase;
	public static float moneyPerBrickUpgradeCostMultiplier;

	//TODO: XP - Leveling up and stuff...
	//public int level;
	//public int xp;
	//public float xpMultiplier;
	//public int xpPerBrick;
	//public int xpPerBrick_upgradeBase;
	//public float xpPerBrick_upgradeMultiplier;
	//... and other variables to get XP Threshold for level up, etc...

	//Damage
	[Header("Damage")]
	public static int damageUpgradeLevel;
	public static int damageUpgrageBase;
	public static float damageUpgradeMultiplier;
	public static int damageUpgradeCostBase; 
	public static float damageUpgradeCostMultiplier;

	//Skill
	[Header("Skill")]
	public static int skill1DamageUpgradeLevel;
	public static int skill1DamageUpgradeBase;
	public static int skill1DamageUpgradeMultiplier;
	public static int skill1DamageUpgradeCostBase;
	public static int skill1DamageUpgradeCostMultiplier;

	public static int skill1RechargeUpgradeLevel;
	public static int skill1RechargeUpgradeBase;
	public static int skill1RechargeUpgradeMultiplier;
	public static int skill1RechargeUpgradeCostBase;
	public static int skill1RechargeUpgradeCostMultiplier;


	//Get methods:
	int getMoneyPerBrick ()
	{
		return 10; //Fixed for now...
	}

	int getMoneyPerBrickUpgradePrice ()
	{
		return 10; //Fixed for now...
	}

	int getDamage ()
	{
		return 10; //Fixed for now...
	}

	int getDamageUpgradePrice ()
	{
		return 10; //Fixed for now...
	}


	int getSkill1Damage ()
	{
		return 10; //Fixed for now...
	}

	int getSkill1DamageUpgradePrice ()
	{
		return 10; //Fixed for now...
	}

	int getSkill1Recharge ()
	{
		return 10; //Fixed for now...
	}

	int getSkill1RechargeUpgradePrice ()
	{
		return 10; //Fixed for now...
	}



	//Change Money inventory

	void addMoney ()
	{
		moneyAmount += getMoneyPerBrick();
	}

	void buyUpgrade ()
	{
		//TODO: for later!
	}

}

using UnityEngine;
using System.Collections;

public class ResourceController : MonoBehaviour {

	//Money
	[Header("Money")]
	public int moneyAmount;
	public int initialMoney;

	public int moneyPerBrickUpgradeLevel;
	public int moneyPerBrickUpgrageBase;
	public float moneyPerBrickUpgradeMultiplier;
	public int moneyPerBrickUpgradeCostBase;
	public float moneyPerBrickUpgradeCostMultiplier;

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
	public int damageUpgradeLevel;
	public int damageUpgrageBase;
	public float damageUpgradeMultiplier;
	public int damageUpgradeCostBase;
	public float damageUpgradeCostMultiplier;

	//Skill
	[Header("Skill")]
	public int skill1DamageUpgradeLevel;
	public int skill1DamageUpgradeBase;
	public int skill1DamageUpgradeMultiplier;
	public int skill1DamageUpgradeCostBase;
	public int skill1DamageUpgradeCostMultiplier;

	public int skill1RechargeUpgradeLevel;
	public int skill1RechargeUpgradeBase;
	public int skill1RechargeUpgradeMultiplier;
	public int skill1RechargeUpgradeCostBase;
	public int skill1RechargeUpgradeCostMultiplier;

	//Spawn
	[Header("Spawn")]
	public float spawnInterval;

	//Block
	[Header("Block")]
	private int blocksDestroyed;
	public int blocksDestroyedPerLevel;
	public int blockMinHealthBase;
	public int blockMinHealthMultiplier;
	public int blockMaxHealthBase;
	public int blockMaxHealthMultiplier;

	//Game Over
	[Header("Game Over")]
	public float gameOverThreshold;


	//Get methods:
	public int getMoneyPerBrick ()
	{
		return 10; //Fixed for now...
	}

	public int getMoneyPerBrickUpgradePrice ()
	{
		return 10; //Fixed for now...
	}

	public int getDamage ()
	{
		return 10; //Fixed for now...
	}

	public int getDamageUpgradePrice ()
	{
		return 10; //Fixed for now...
	}

	public int getSkill1Damage ()
	{
		return 10; //Fixed for now...
	}

	public int getSkill1DamageUpgradePrice ()
	{
		return 10; //Fixed for now...
	}

	public int getSkill1Recharge ()
	{
		return 10; //Fixed for now...
	}

	public int getSkill1RechargeUpgradePrice ()
	{
		return 10; //Fixed for now...
	}

	// Block methods

	public void incrementBlocksDestroyed ()
	{
		blocksDestroyed++;
	}

	public int getBlocksDestroyed ()
	{
		return blocksDestroyed;
	}

	public int getBlockMinHealth ()
	{
		return blockMinHealthBase + blockMinHealthMultiplier * (blocksDestroyed / blocksDestroyedPerLevel);
	}
	public int getBlockMaxHealth ()
	{
		return blockMaxHealthBase + blockMaxHealthMultiplier * (blocksDestroyed / blocksDestroyedPerLevel);
	}

	//Change Money inventory

	public void addMoney ()
	{
		moneyAmount += getMoneyPerBrick();
	}

	public void buyUpgrade ()
	{
		//TODO: for later!
	}

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjEnemyHpManager : MonoBehaviour {

	public int maxHealth;
	public int currentHealth;
	private gpjPlayerStats thePlayerStats;
	public int expToGive;
	public string enemyQuestName;
	private gpjQuestManager theQM;

	private SFXManager sfxMan;

	// Use this for initialization
	void Start () {
		sfxMan = FindObjectOfType<SFXManager>();
		currentHealth = maxHealth;
		
		thePlayerStats = FindObjectOfType<gpjPlayerStats>();

		theQM = FindObjectOfType<gpjQuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0) {

			theQM.enemyKilled = enemyQuestName;

			Destroy(gameObject);
			thePlayerStats.AddExp(expToGive);
		}
	}

	public void HurtEnemy(int damageToGive){
		sfxMan.hurtEnemy.Play();
		currentHealth -= damageToGive;
	}

	public void SetMaxHealth(){
		currentHealth = maxHealth;
	}

}

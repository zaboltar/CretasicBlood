﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gpjUIManager : MonoBehaviour {

	public Slider healthBar;
	public Text healthText;
	public Text levelText;
	public gpjHealthManager playerHealth;
	private gpjPlayerStats thePs;
	private collectIdol collectIdol;

	public Text collectableCount;
	// public static bool canvasExists;
	
	// Use this for initialization
	void Start () {
		// if(!canvasExists){
  //           canvasExists = true;
  //           DontDestroyOnLoad(transform.gameObject);
  //       }else{
  //           Destroy(gameObject);
  //       }
		thePs = GetComponent<gpjPlayerStats>();
		collectIdol = GetComponent<collectIdol>();

	}
	
	// Update is called once per frame
	void Update () {
		healthBar.maxValue = playerHealth.playerMaxHealth;
		healthBar.value = playerHealth.playerCurrentHealth;
		healthText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
		levelText.text = "Lvl: " + thePs.currentLevel;
		collectableCount.text = "Idols: " + playerHealth.collectedTreasures;
	}
}

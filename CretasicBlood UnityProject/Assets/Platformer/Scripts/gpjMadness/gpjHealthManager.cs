using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjHealthManager : MonoBehaviour {


	public int playerMaxHealth;
	public int playerCurrentHealth;

	private bool flashActive;
	public float flashLength;
	private float flashCounter;

	private SpriteRenderer playerSprite;

	public int collectedTreasures;
	// private gpjUIManager canvas;
	private SFXManager sfxMan;
	private gpjPlayerStats playerStats;
	
	// Use this for initialization
	void Start () {
		
		playerCurrentHealth = playerMaxHealth;
		// playerStats = FindObjectOfType<gpjPlayerStats>();
		playerSprite = GetComponent<SpriteRenderer>();
		// canvas = FindObjectOfType<gpjUIManager>();
		sfxMan = FindObjectOfType<SFXManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerCurrentHealth <= 0) {
			SFXManager.sfxManExists = false;
			//Destroy(gameObject);
			// Destroy(playerStats.gameObject);
			//Destroy(sfxMan.gameObject);
			// Destroy(canvas.gameObject);
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);  
		}

		if (flashActive) {

			if (flashCounter > flashLength * .66f){
				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
				} else if (flashCounter > flashLength * .33f){
					playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
				} else if (flashCounter > 0f) {
					playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
				
				} else {

				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
				flashActive = false;
			}


			flashCounter -= Time.deltaTime;
		}




	}

	public void HurtPlayer(int damageToGive){
		playerCurrentHealth = playerCurrentHealth - damageToGive;

		flashActive = true;
		flashCounter = flashLength;
		sfxMan.auch.Play();

	}

	public void SetMaxHealth(){
		playerCurrentHealth = playerMaxHealth;
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "health"){
			playerCurrentHealth += 5;
			sfxMan.haaa.Play();
			Destroy(other.gameObject);
		}

		if (other.tag == "collectableIdol") {
			collectedTreasures++;
			sfxMan.getIdol.Play();
			Destroy(other.gameObject);

		}
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

	public AudioSource auch;
	public AudioSource dead;
	public AudioSource haaa;
	public AudioSource getIdol;
	public AudioSource soosh;
	public AudioSource hurtEnemy;

	public static bool sfxManExists;

	// Use this for initialization
	void Awake () {
		if(!sfxManExists){
			sfxManExists = true;
			DontDestroyOnLoad(transform.gameObject);
		}else{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

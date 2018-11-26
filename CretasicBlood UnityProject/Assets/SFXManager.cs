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
	public AudioSource doorOpens;

	public static bool sfxManExists;

	static public SFXManager sfxM;

	// Use this for initialization
	void Start () {
		/*if (sfxM == null) {
			sfxM = this;
			DontDestroyOnLoad(transform.gameObject);
			}else{
			Destroy(gameObject);

		/*if(!sfxManExists){
			sfxManExists = true;
			DontDestroyOnLoad(transform.gameObject);
		}else{
			Destroy(gameObject);
		}*/

		//} 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

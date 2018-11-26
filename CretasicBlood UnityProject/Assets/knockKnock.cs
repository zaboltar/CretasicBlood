using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class knockKnock : MonoBehaviour {
Animator anim;
private SFXManager sfxMan;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		sfxMan = FindObjectOfType<SFXManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag("Player")) {
			anim.SetTrigger("Open");
			sfxMan.doorOpens.Play();
		}
	}

}

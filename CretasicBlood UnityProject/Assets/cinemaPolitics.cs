﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cinemaPolitics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(JumpToScene());
	}

	IEnumerator JumpToScene() {
		yield return new WaitForSeconds(12f);
		SceneManager.LoadScene(1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

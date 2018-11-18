using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagmite : MonoBehaviour {

	public GameObject woodSpike;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Player") ) {
			woodSpike.GetComponent<Rigidbody2D>().gravityScale = 1;
		}
	}
}

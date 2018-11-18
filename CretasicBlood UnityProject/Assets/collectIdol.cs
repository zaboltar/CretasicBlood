using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectIdol : MonoBehaviour {


	public int collectedTreasures;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "collectableIdol") {
			collectedTreasures++;
			Destroy(other.gameObject);

		}
	}


}

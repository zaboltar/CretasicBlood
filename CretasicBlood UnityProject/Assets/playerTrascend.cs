using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTrascend : MonoBehaviour {

	static public playerTrascend pT;

	// Use this for initialization
	void Awake() {
		 if (pT == null) {

            pT = this;
            DontDestroyOnLoad(transform.gameObject);
        } else {
            Destroy(gameObject);    
        }
	}
	
	
}

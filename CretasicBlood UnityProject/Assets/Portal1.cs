using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D other) { 
	   if ( other.CompareTag("stonePortalTo2"))
        {

        	Debug.Log("Toca");
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);  
            
        }

	}


}

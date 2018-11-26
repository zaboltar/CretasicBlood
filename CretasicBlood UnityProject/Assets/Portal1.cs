using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D other) { 

        //NOTA: esta parte del código está hecha explícitamente para que los puristas de la eficiencia
        // procesal se quejen arduamente. Y con razón.

		//(hacer un switch acá, lol)
	   if ( other.CompareTag("stonePortalTo2"))
        {        
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);  
        }

         if ( other.CompareTag("stonePortalTo3"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3); 
        }

          if ( other.CompareTag("stonePortalTo4"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(4); 
        }

           if ( other.CompareTag("stonePortalTo5"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(5); 
        }

         if ( other.CompareTag("stonePortalTo6"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6); 
        }

          if ( other.CompareTag("StonePortalToEnd"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(9); 
        }
        
        

	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour {

	private PhysicsPlatformMov2D player;

	// Use this for initialization
	void Start () {
			player = FindObjectOfType<PhysicsPlatformMov2D>();
			player.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

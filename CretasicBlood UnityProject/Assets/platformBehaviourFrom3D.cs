﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehaviourFrom3D : MonoBehaviour {


	Vector3 startPoint;
    Vector3 currentTarget;
    public Vector3 targetPoint;
    public float speed;

	// Use this for initialization
	void Start () {
		 startPoint = transform.position;
        currentTarget = targetPoint;
	}
	
	// Update is called once per frame
	void Update () {

		 if (transform.position == currentTarget) {
            currentTarget = (currentTarget == targetPoint) ? startPoint : targetPoint;
       }
        
        transform.position = Vector2.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

	}       
	
	  void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(startPoint, Vector3.one * 0.25f);
        Gizmos.DrawCube(targetPoint, Vector3.one * 0.25f);

    }

}

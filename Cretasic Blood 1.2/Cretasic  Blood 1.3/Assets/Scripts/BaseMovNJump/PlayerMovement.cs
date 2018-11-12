using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = false;
	public int playerJumpPower = 1250;
	private float moveX;

	
	void Start () {
		
	}
	
	
	void Update () {
		PlayerMove();
	}

	void PlayerMove(){
		// controls
		moveX = Input.GetAxis("Horizontal");

					// jump
		if(Input.GetButtonDown ("Jump")){
			Jump();
		}

		// animations

		// player direction
		if (moveX < 0.0f && facingRight == false) {
			FlipPlayer();
		} else if (moveX > 0.0f && facingRight == true) {
			FlipPlayer();
		}

		// physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y );
	}

	void Jump() {
		// jumping code
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
	}

	void FlipPlayer(){
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}

}

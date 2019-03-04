using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour {

	Rigidbody2D rigidBody2D;
	private float forwardForce = 0.2f;
	private float jumpForce = 8f;

	void Start () 
	{
		rigidBody2D = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		
	}

	public void jump()
	{
			rigidBody2D.velocity = new Vector2 (forwardForce, jumpForce);
	}
}

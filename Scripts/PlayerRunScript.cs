using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunScript : MonoBehaviour {

	public float speed = 5f;
	bool movingRight = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (movingRight) 
		{
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			GetComponent<SpriteRenderer> ().flipX = false;
		} 
		else {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			GetComponent<SpriteRenderer> ().flipX = true;
		}
	}

	void OnCollisionEnter2D(Collision2D collision2D){
	
		if (collision2D.gameObject.tag == "Boundary") 
		{
			movingRight = !movingRight;
		}
	}

}

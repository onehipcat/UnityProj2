using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	Rigidbody2D rb;
	SpriteRenderer spr;
	Animator anim;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		spr = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
		
	}

	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical")) * 4.0f;


//		if (Input.GetKey ("right")) {
//			rb.velocity = new Vector2 (1.0f, 0.0f);
//			anim.SetBool ("IsWalking", true);
//		}
//		if (Input.GetKey ("left")) {
//			rb.velocity = new Vector2 (-1.0f, 0.0f);
//			anim.SetBool ("IsWalking", true);
//		}
//		if (Input.GetKey ("up")) {
//			rb.velocity = new Vector2 (0.0f, 1.0f);
//			anim.SetBool ("IsWalking", true);
//		}
//		if (Input.GetKey ("down")) {
//			rb.velocity = new Vector2 (0.0f, -1.0f);
//			anim.SetBool ("IsWalking", true);
//		}
		if (rb.velocity.magnitude == 0f) {
			anim.SetBool ("IsWalking", false);
		} else{
			anim.SetBool ("IsWalking", true);
		}
			
		if (rb.velocity.x > 0f) {
			spr.flipX = true;
			Debug.Log ("flip");
		} else if (rb.velocity.x < -0.1f) {
			spr.flipX = false;
		}
	}
}

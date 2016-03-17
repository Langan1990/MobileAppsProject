using UnityEngine;
using System.Collections;

public class CharacterCode : MonoBehaviour {

	public float maxS = 11f;
	bool right = true;

	Animator a;

	bool ground = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public float jumpForce = 700f;
	public LayerMask wiGround;

	void Start () 
	{
		a = GetComponent<Animator> ();
	}
	

	void Update()
	{
		if (ground && Input.GetKeyDown (KeyCode.Space)) {
			a.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
		
		}
	}


	void FixedUpdate () 
	{

		ground = Physics2D.OverlapCircle (groundCheck.position, groundRadius, wiGround);
		a.SetBool ("Ground", ground);
				a.SetFloat ("vertSpeed", GetComponent<Rigidbody2D> ().velocity.y);


		float move = Input.GetAxis ("Horizontal");
		a.SetFloat ("Speed", Mathf.Abs (move));
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxS, GetComponent<Rigidbody2D> ().velocity.y);

		if (move > 0 && !right)
			Flip ();
		else 
		{
			if (move < 0 && right)
				Flip();
		}
	}

	void Flip()
	{
		right = !right;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;

	}



}

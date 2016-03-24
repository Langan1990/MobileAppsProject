using UnityEngine;
using System.Collections;

public class CharacterCode : MonoBehaviour {

	public float maxS = 15f;
	//bool right = true;

	Animator a;
	Rigidbody2D myRigidBody;

	bool ground = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public float jumpForce = 700f;
	public LayerMask wiGround;

	bool dJump = false;


	void Start () 
	{
		a = GetComponent<Animator> ();
		myRigidBody = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		if ((ground || !dJump) && Input.GetKeyDown (KeyCode.Space)) {
			a.SetBool("Ground", false);
			myRigidBody.AddForce(new Vector2(0, jumpForce));

			if (!dJump && !ground)
			{
				dJump = true;
			}
		}
	}


	void FixedUpdate () 
	{
		ground = Physics2D.OverlapCircle (groundCheck.position, groundRadius, wiGround);
		a.SetBool ("Ground", ground);
		a.SetFloat ("vertSpeed", myRigidBody.velocity.y);

		if (ground) 
		{
			dJump = false;
		}

		float move = Input.GetAxis ("Horizontal");
		a.SetFloat ("Speed", Mathf.Abs (maxS));


		// moving the player to the right!
		myRigidBody.velocity = new Vector2(maxS, myRigidBody.velocity.y );

	
	}





}

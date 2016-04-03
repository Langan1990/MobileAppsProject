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

    AudioSource Audio;


    void Start () 
	{
		a = GetComponent<Animator> ();//gets the animator component
		myRigidBody = GetComponent<Rigidbody2D> ();//gets the rigidbodycomponenet

        float volume = PlayerPrefs.GetInt("Volume");// Gets the volume
        Audio.volume = volume;
    }

	void Update()
	{

        if ((ground || !dJump) && (Input.GetKeyDown (KeyCode.Space) || (Input.GetMouseButtonDown(0))))// if the player is on the ground OR not after double jumping AND space bar OR mouse are pressed
        {
			a.SetBool("Ground", false);// set the ground variable to false
			myRigidBody.AddForce(new Vector2(0, jumpForce));//and use jumpforce to make the player jump

			if (!dJump && !ground)//if you havent used the doublejump AND your not on the ground
			{
				dJump = true;//set double jump to true
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

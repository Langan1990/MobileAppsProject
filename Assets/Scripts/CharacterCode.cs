using UnityEngine;
using System.Collections;

public class CharacterCode : MonoBehaviour {

	public float maxS = 15f;
	//bool right = true;

	Animator a;
	Rigidbody2D myRigidBody;

	bool ground = false;//declare boolean variable for if the character is on the ground or not
	public Transform groundCheck;//variable for the position of the ground check
	float groundRadius = 0.2f;
	public float jumpForce = 700f;//variable for the force of the jump
	public LayerMask wiGround;

	bool dJump = false;//boolean variable for double jump

    AudioSource Audio;


    void Start () 
	{
		a = GetComponent<Animator> ();//gets the animator component
		myRigidBody = GetComponent<Rigidbody2D> ();//gets the rigidbodycomponenet

        float volume = PlayerPrefs.GetInt("Volume");// Gets the volume
        //Audio.volume = volume;
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
		ground = Physics2D.OverlapCircle (groundCheck.position, groundRadius, wiGround);//gets the position of the ground and stores it
		a.SetBool ("Ground", ground);//sets the boolean fo whether the character is on the ground or not
		a.SetFloat ("vertSpeed", myRigidBody.velocity.y);//makes the character go up the y axis by the vertspeed

		if (ground) //if on the ground
		{
			dJump = false;//doublejump is false
		}

		float move = Input.GetAxis ("Horizontal");
		a.SetFloat ("Speed", Mathf.Abs (maxS));


		// moving the player to the right!
		myRigidBody.velocity = new Vector2(maxS, myRigidBody.velocity.y );

	
	}





}

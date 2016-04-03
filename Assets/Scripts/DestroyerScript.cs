using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

   


    void OnTriggerEnter2D(Collider2D other)//method for collision detection
    {
		if (other.tag == "Player") //if the player collides with the object
        {
			Application.LoadLevel(2);//load the gameoverscene
            
			
		}


		if (other.gameObject.transform.parent) {//if any other object hits this oject
			Destroy (other.gameObject.transform.parent.gameObject);		//destroy this object
		} else
		{
			Destroy(other.gameObject);//destroy this object
		}
	}


}

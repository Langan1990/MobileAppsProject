using UnityEngine;
using System.Collections;

public class Powerupscript : MonoBehaviour {

    HUDscript hud;

    void OnTriggerEnter2D(Collider2D other)//method for collision detection
    {
        if (other.tag == "Player")//if the player collides with the object
        {
            hud = GameObject.Find("Main Camera").GetComponent<HUDscript>();//find the hudscript in the 'main camera' object
            hud.IncreaseScore(10);//increase the score
            Destroy (this.gameObject);//destroy this object
        }
    }

    }

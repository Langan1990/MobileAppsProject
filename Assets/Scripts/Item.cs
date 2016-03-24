using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	HUD hud;

	void onTriggerEnter2D(Collider2D other)
	{
		 if (other.tag == "Chara")
		{
			hud = GameObject.Find("Main Camera").GetComponent<HUD>();
			hud.increaseScore(10);
			Destroy (this.gameObject);
		}
	}
}

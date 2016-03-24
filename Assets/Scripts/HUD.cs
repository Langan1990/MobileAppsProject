using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	float playerScore = 0f;


	void Update () {
		playerScore += Time.deltaTime;
	}



	public void increaseScore(int score)
	{
		playerScore += score;
	}
	void onGUI()
	{
		GUI.Label(new Rect(10,10, 100, 400), "SCORE: " +(int)(playerScore * 100));
		//GUI.contentColor;
	}

}

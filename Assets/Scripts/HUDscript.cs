using UnityEngine;
using System.Collections;

public class HUDscript : MonoBehaviour {



	float playerScore = 0;
    float highscore = 0;







	// Update is called once per frame
	void Update () {
	
		playerScore += Time.deltaTime;//increases the score by the time

	}

	public void IncreaseScore(int amount)
	{
		playerScore += amount;// add the score to the amount

	}

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)(playerScore * 10));//stores the score to be used in the gameoverscript
    }



	void OnGUI()
	{
		GUI.color = Color.black;//sets the colour to black
		GUI.Label(new Rect(10, 10, 100, 30), "SCORE: " + (int) (playerScore * 10));//creates a gui label in the corner and displays the score

	}
}

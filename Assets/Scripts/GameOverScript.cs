using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    int score = 0;//declare variable for score
    int highScore ;//variable for high score

    

    
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");// Gets the score from the hudscript
        highScore = PlayerPrefs.GetInt("High Score");// Gets the high score 

    }

    void Update()
    {
       
        //scorecount.text = ("" + score);
        if (score > highScore)//if the scoreis greater than the high score
        {
            highScore = score;//highscore takes the value of score
            PlayerPrefs.SetInt("High Score", highScore);//stores the high score
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, Screen.height / 2 -10, 80, 30), "Score:" + score);// label to display the score
        GUI.Label(new Rect(Screen.width / 2 - 55, Screen.height / 2 + 20 , 100, 30), "High Score:" + highScore);// label to display the high score
    }



    public void Retry()// retry button method
    {
        Application.LoadLevel(1);//loads the mainscene
    }


    public void Quit()//quit button method
    {
        Application.LoadLevel(0);//loads the mainmenuscene 
    }


 
}

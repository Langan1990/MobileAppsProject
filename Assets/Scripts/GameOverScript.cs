using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    int score = 0;
    int highScore ;

    public Text scorecount ;

    
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");// Gets the score from the hudscript
    
        
    }

    void Update()
    {
       
        //scorecount.text = ("" + score);
        if (score > highScore)
        {
            highScore = score;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, Screen.height / 2, 80, 30), "Score:" + score);// label to display the score, should fix it
        GUI.Label(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 50 , 100, 30), "High Score:" + highScore);// label to display the high score, should fix it
    }



    public void Retry()// retry button method
    {
        Application.LoadLevel(1);//loads the mainscene
    }


    public void Quit()//quit button method
    {
        Application.Quit();//quits the application 
    }
}

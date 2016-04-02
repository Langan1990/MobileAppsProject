using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    

    public void StartGame()//start game button method
    {
        Application.LoadLevel(1);// loads the mainscene
    }

    public void QuitGame()//quit game button method
    {
        Application.Quit();//quit the application
    }

    public void Settings()//start game button method
    {
        Application.LoadLevel(3);// loads the mainscene
    }
}

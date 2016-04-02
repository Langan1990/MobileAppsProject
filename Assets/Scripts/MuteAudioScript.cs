using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MuteAudioScript : MonoBehaviour {

    AudioSource Audio;

    bool pressed;
 

	// Use this for initialization
	public void Start () {
       // Audio = GameObject.Find("ACE Rhythm n' Lead").GetComponent<AudioSource>();//find the hudscript in the 'main camera' object
        pressed = GameObject.Find("Audio").GetComponent<Toggle>();
        //  Audio = GetComponent<AudioSource>();

    }



   public void Mute()
    {
        if (pressed == true)
        {
            Audio.mute = false;
        }
        else
        {
            Audio.mute = true;
        }

        
    }

    

    public void Toggle_changed(bool newValue)
    {
        pressed = newValue;

    }





    public void MainMenu()//start game button method
    {
        Application.LoadLevel(0);// loads the mainscene
    }
}

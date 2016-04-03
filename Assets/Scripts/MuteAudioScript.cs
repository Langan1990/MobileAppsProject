using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MuteAudioScript : MonoBehaviour {

    AudioSource Audio;

    bool pressed;
 

	// Use this for initialization
	public void Start () {
      //  Audio = GameObject.Find("Music").GetComponent<AudioSource>();//find the hudscript in the 'main camera' object
       // pressed = GameObject.Find("Audio").GetComponent<Toggle>();
        //  Audio = GetComponent<AudioSource>();

    }

    public void Update()
    {
        
    }

    

   // public void Volume(float volume)
    //{
     //   Audio.volume = volume;
       // PlayerPrefs.SetFloat("Volume", volume);//stores the volume
   // }



    public void MainMenu()//start game button method
    {
        Application.LoadLevel(0);// loads the mainscene
    }
}

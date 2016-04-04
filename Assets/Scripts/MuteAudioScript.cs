using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MuteAudioScript : MonoBehaviour {

    


    private float slider = 1.0f;
	private float volume = 1.0f;
	public Slider volumeSlider;


	void Start () {
		//loads the currently saved volume on each scene
		volumeSlider.value = PlayerPrefs.GetFloat ("Volume Slider", volumeSlider.value);
	}


	public void VolumeSlider () {
		volume = volumeSlider.value;//sets the volume variable to be the same as the slider
		PlayerPrefs.SetFloat("Volume Slider", volumeSlider.value);//sets the value of the slider
		AudioListener.volume = volume;
		PlayerPrefs.SetFloat("Audio Volume", volume);//sets the value of the volume 
	}
	

    

    public void MainMenu()//start game button method
    {
        Application.LoadLevel(0);// loads the mainscene
    }
}

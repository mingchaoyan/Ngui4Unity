using UnityEngine;
using System.Collections;

public class VolumeManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //We will need the Slider
    UISlider slider;
    void Awake ()
    {
        //Get the Slider
        slider = GetComponent<UISlider>();
        //Set the Slider's value to last saved volume
        slider.value = NGUITools.soundVolume;
    }

    public void OnVolumeChange ()
    {
        //Change NGUI's UI Sounds volume
        NGUITools.soundVolume = UISlider.current.value;
        //Change the Game AudioListener's volume
        AudioListener.volume = UISlider.current.value;
    }
}

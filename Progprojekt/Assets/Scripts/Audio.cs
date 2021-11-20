using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
    private bool muted;

    void Start()
    {
        if(!PlayerPrefs.HasKey("volume"))       //gets called when playerpref doesnt have the "volume", so if no volume was set beforehand it will be set to one
        {
            PlayerPrefs.SetFloat("volume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }



    public void MuteButton(bool mute)
    {
        if(mute)
        {
            AudioListener.volume = 0;
            muted = true;
            PlayerPrefs.SetFloat("volume",0);

        }
        else
        {
            AudioListener.volume = VolumeSlider.value;
            muted = false;
            Save();
        }
    }


    public void VolSlider()
    {
        if (muted == false)
        {
            AudioListener.volume = VolumeSlider.value;
            Save();
        }
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", VolumeSlider.value);
    }

    private void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("volume");
    }
}

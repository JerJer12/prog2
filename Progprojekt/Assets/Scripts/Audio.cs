using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource music;
   // [SerializeField] AudioSource sfx;
    [SerializeField] Slider VolumeSlider;
    [SerializeField] Slider MusicVolumeSlider;
   // [SerializeField] Slider SfxVolumeSlider;
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
        //test

        if (!PlayerPrefs.HasKey("Musicvolume"))     
        {
            PlayerPrefs.SetFloat("Musicvolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        /*
        if (!PlayerPrefs.HasKey("Sfxvolume"))       //gets called when playerpref doesnt have the "volume", so if no volume was set beforehand it will be set to one
        {
            PlayerPrefs.SetFloat("Sfxvolume", 1);
            Load();
        }
        else
        {
            Load();
        }
        */
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

    //test begin
    public void MusicVolSlider()
    {
        if (muted == false)
        {
            music.volume = MusicVolumeSlider.value;
            Save();
        }
    }

    /*
    public void SfxVolSlider()
    {
        if (muted == false)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                sfx[i].volume = SfxVolumeSlider.value;
                
            }
            
            sfx.volume = SfxVolumeSlider.value;
            Save();
        }
    }
    */
    //test end

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", VolumeSlider.value);
        PlayerPrefs.SetFloat("Musicvolume", MusicVolumeSlider.value);
        //PlayerPrefs.SetFloat("Sfxvolume", SfxVolumeSlider.value);
    }

    private void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("volume");
        MusicVolumeSlider.value = PlayerPrefs.GetFloat("Musicvolume");
        //SfxVolumeSlider.value = PlayerPrefs.GetFloat("Sfxvolume");

    }

    
}

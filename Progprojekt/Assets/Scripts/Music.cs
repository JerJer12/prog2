using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Music : MonoBehaviour

{
    [SerializeField] string volParameter = "Music_vol";
    [SerializeField] AudioMixer _mixer;
    [SerializeField] Slider MusSlider;
    [SerializeField] float multi = 30f;



    private void Awake()
    {
        MusSlider.onValueChanged.AddListener(SliderValueChanged);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volParameter, MusSlider.value);
    }

    public void SliderValueChanged(float value)
    {
        _mixer.SetFloat(volParameter, Mathf.Log10(value)*multi);
    }

    // Start is called before the first frame update
    void Start()
    {
        MusSlider.value = PlayerPrefs.GetFloat(volParameter, MusSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

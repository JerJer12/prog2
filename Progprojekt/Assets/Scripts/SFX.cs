using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFX : MonoBehaviour

{
    [SerializeField] string volParameter = "Sfx_vol";
    [SerializeField] AudioMixer _mixer;
    [SerializeField] Slider SfxSlider;
    [SerializeField] float multi = 30f;



    private void Awake()
    {
        SfxSlider.onValueChanged.AddListener(SliderValueChanged);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volParameter, SfxSlider.value);
    }

    public void SliderValueChanged(float value)
    {
        _mixer.SetFloat(volParameter, Mathf.Log10(value) * multi);
    }

    // Start is called before the first frame update
    void Start()
    {
        SfxSlider.value = PlayerPrefs.GetFloat(volParameter, SfxSlider.value);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

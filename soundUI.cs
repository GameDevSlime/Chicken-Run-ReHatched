using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class soundUI : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider masterSlider;
    public Slider SFXSlider;
    // Start is called before the first frame update
    void Start()
    {
        SetVolume("MasterVolume",1);
    }

    // Update is called once per frame
    public void SetMasterVolume(){
        SetVolume("MasterVolume",masterSlider.value);
    }

    public void SetSFXVolume(){
        SetVolume("SFX",SFXSlider.value);
    }

    void SetVolume(string name, float value){
        float volume = Mathf.Log10(value) * 20;
        if(value == 0){
            volume = -80;
        }
        audioMixer.SetFloat(name, volume);
    }
}

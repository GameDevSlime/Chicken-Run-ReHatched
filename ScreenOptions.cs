using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenOptions : MonoBehaviour
{
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;
    public Toggle isFullScreen;

    void Start()
    {
        resolutions = Screen.resolutions;
        isFullScreen.isOn = Screen.fullScreen;
        for(int i = 0; i < resolutions.Length; i++){
            string resolutionString = resolutions[i].width.ToString() + "x" + resolutions[i].height.ToString();
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolutionString)); 
        }
    }

    public void SetResolution(){
        Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, isFullScreen.isOn);
    }

}
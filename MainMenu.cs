using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Level1Scene");
    }

    public void Quit(){
        Application.Quit();
    }

    public void HowTo(){
        SceneManager.LoadScene("HowTo");
    }
}

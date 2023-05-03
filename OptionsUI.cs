using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsUI : MonoBehaviour
{
    public void OpenMenu(){
        GetComponent<Canvas>().enabled = true;
    }

    public void close(){
        GetComponent<Canvas>().enabled = false;
    }

    public void Reset(){
        SceneManager.LoadScene("MainMenu");
    }
}

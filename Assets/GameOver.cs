using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void gameover(){
        SceneManager.LoadScene("MainMenu");
    }
}

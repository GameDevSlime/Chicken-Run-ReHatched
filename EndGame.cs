using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.CompareTag("Player")){
        Debug.Log("GameOver");
        SceneManager.LoadScene("GameOver");
        Destroy(other.gameObject);
        }
        
    }
    
}
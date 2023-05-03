using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour
{

    [Header("Text Elements")]
    public Text pointText;
    public Animation_State_Changer asc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other collider is the player
        if (other.CompareTag("Player"))
        {
            
            if(pointText.text == "5"){
            // Wait for 3 seconds
            asc.ChangingAnimationState("Switch On");
            StartCoroutine(DestroyButtonAfterDelay(3f));
            }
        }
    }

    private IEnumerator DestroyButtonAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Destroy the button game object
        Destroy(gameObject);
    }
}

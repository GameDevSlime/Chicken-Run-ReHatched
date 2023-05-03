
using UnityEngine;
using UnityEngine.UI;

public class EggContact : MonoBehaviour
{
    public Image imageToUpdate; // Reference to the Image component that needs to be updated
    public Sprite newSprite; // Reference to the new Sprite to use for the Image component

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other collider is the player
        if (other.CompareTag("Player"))
        {
            // Destroy the game object this script is attached to
            Destroy(gameObject);

            // Update the Image component with the new Sprite
            imageToUpdate.sprite = newSprite;
        }
    }
}
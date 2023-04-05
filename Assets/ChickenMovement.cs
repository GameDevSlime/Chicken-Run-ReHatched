using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    private float timeSinceLastMove = 0f;
    private Vector2 currentDirection;
    public Animation_State_Changer asc;
    // Start is called before the first frame update
    void Start()
    {
        currentDirection = GetNewDirection();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastMove += Time.deltaTime;

        if (timeSinceLastMove >= 4f)
        {
            currentDirection = GetNewDirection();
            timeSinceLastMove = 0f;
        }

        // Move the object in the current direction
        transform.position += new Vector3(currentDirection.x, currentDirection.y, 0f) * moveSpeed * Time.deltaTime;

        if (currentDirection.x > 0f)
        {
            Debug.Log("Object is moving right.");
            asc.ChangingAnimationState("ChickenRight");
        }
        else if (currentDirection.x < 0f)
        {
            Debug.Log("Object is moving left.");
            asc.ChangingAnimationState("ChickenLeft");
        }

        if (currentDirection.y > 0f)
        {
            Debug.Log("Object is moving up.");
            asc.ChangingAnimationState("ChickenBack");
        }
        else if (currentDirection.y < 0f)
        {
            Debug.Log("ChickenFoward");
            asc.ChangingAnimationState("ChickenFoward");
        }
}

private Vector2 GetNewDirection()
    {
        // Generate a random direction vector with x or y component set to zero
        float rand = Random.value;
        Vector2 direction = rand < 0.5f ? new Vector2(Random.Range(-1f, 1f), 0f) : new Vector2(0f, Random.Range(-1f, 1f));

        return direction;
    }

}

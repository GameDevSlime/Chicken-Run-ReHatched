using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 5f;

    private Vector2 lastPosition;
    public Animation_State_Changer asc;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;
        Vector2 targetPosition = target.position;
        Vector2 direction = targetPosition - currentPosition;
        transform.position = Vector2.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);
        
        if (currentPosition != lastPosition)
        {
            if (direction.x > 0)
            {
                asc.ChangingAnimationState("BatRight");//right
            }
            else if (direction.x < 0)
            {
                asc.ChangingAnimationState("BatLeft");//left
            }
            if (direction.y > 0)
            {
                asc.ChangingAnimationState("BatBack");//up
            }
            else if (direction.y < 0)
            {
                asc.ChangingAnimationState("BatFoward");//down
            }
        }

        lastPosition = currentPosition;
    }
}

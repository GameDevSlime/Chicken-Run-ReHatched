using UnityEngine;

public class FireLeftRight : MonoBehaviour
{
    public float moveDistance = 2f;
    public float moveSpeed = 2f;

    private float leftBound;
    private float rightBound;
    private bool movingLeft = true;
    private float timer = 0f;

    void Start()
    {
        leftBound = transform.position.x - moveDistance;
        rightBound = transform.position.x + moveDistance;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f)
        {
            timer = 0f;
            movingLeft = !movingLeft;
        }

        if (movingLeft)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(leftBound, transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(rightBound, transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);
        }
    }
}

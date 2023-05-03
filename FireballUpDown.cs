using UnityEngine;

public class FireballUpDown : MonoBehaviour
{
    public float moveDistance = 2f;
    public float moveSpeed = 2f;

    private float upBound;
    private float downBound;
    private bool movingUp = true;
    private float timer = 0f;

    void Start()
    {
        upBound = transform.position.y + moveDistance;
        downBound = transform.position.y - moveDistance;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f)
        {
            timer = 0f;
            movingUp = !movingUp;
        }

        if (movingUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, upBound, transform.position.z), moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, downBound, transform.position.z), moveSpeed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerHandler : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 offset){
        rb.MovePosition(transform.position + offset);
    }
}

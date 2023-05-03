using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmerMovement : MonoBehaviour
{

    [Header("Movement")]
    public float speed = 3f;
    public Animation_State_Changer asc;

    [Header("Text Elements")]
    int points = 0;
    public Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0)*speed*Time.deltaTime;

        if(Input.GetAxisRaw("Horizontal") == 1){
            asc.ChangingAnimationState("Facing Right");
        }
        else if(Input.GetAxisRaw("Horizontal") == -1){
            asc.ChangingAnimationState("Facing Left");
        }
        else if(Input.GetAxisRaw("Vertical") == 1){
            asc.ChangingAnimationState("Facing Upward");
        }
        else if(Input.GetAxisRaw("Vertical") == -1){
            asc.ChangingAnimationState("Facing Foward");
        }

    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("We collided with the box!");
        if(other.gameObject.tag == "Blue Egg"){
        points+=1;
        }
        if(other.gameObject.tag == "Red Egg"){
        points+=1;
        }
        if(other.gameObject.tag == "Yellow Egg"){
        points+=1;
        }
        if(other.gameObject.tag == "Green Egg"){
        points+=1;
        }
        if(other.gameObject.tag == "Purple Egg"){
        points+=1;
        }
        pointText.text = points.ToString();
    }
}

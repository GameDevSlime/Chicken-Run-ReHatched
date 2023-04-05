using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_State_Changer : MonoBehaviour
{
    public Animator animator;
    public string currentState = "Facing Foward";

    public void ChangingAnimationState(string newState){
        if(currentState == newState){ //already plaing the animation
            return;
        }
        currentState = newState;
        animator.Play(newState);
    }
}

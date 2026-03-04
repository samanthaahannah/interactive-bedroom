using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationScript : MonoBehaviour
{
    Animator anim;
    bool trigged;
    bool closed;
 
    void Start()
    {
        anim = GetComponent<Animator>();
        trigged = false;
        closed = true;

    }

    void OnMouseDown()
    {
        if (trigged)
        {
            anim.SetBool("door_closed", closed);
            closed = !closed;
        }
        else
        {
            anim.SetTrigger("door_trig");
            closed = false;
            trigged = true;
        }
    }
}

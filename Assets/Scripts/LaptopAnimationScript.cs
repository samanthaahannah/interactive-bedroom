using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopAnimationScript : MonoBehaviour
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
        if (trigged == true)
        {
            anim.SetBool("laptop_closed", closed);
            trigged = !trigged;
        }
        else 
        { 
            anim.SetTrigger("laptop_trig");
            closed = false;
            trigged = true;
        }
    }
}

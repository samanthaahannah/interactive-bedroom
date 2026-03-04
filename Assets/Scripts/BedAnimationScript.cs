using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedAnimationScript : MonoBehaviour
{
    Animator anim;
    bool trigged;
    bool covered;

    void Start()
    {
        anim = GetComponent<Animator>();
        trigged = false;
        covered = true;
    }

    void OnMouseDown()
    {
        if (trigged)
        {
            anim.SetBool("covered_up", covered);
            covered = !covered;
        }
        else
        {
            anim.SetTrigger("bed_trig");
            covered = false;
            trigged = true;
        }

    }
}

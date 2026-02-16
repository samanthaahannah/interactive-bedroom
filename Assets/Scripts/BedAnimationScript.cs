using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedAnimationScript : MonoBehaviour
{
    Animator anim;
    bool Trigged;
    bool Covered;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Trigged = false;
        Covered = true;
    }

    void OnMouseDown()
    {
        if (Trigged)
        {
            anim.SetBool("CoveredUp", Covered);
            Covered = !Covered;
        }
        else
        {
            anim.SetTrigger("BedTrig");
            Covered = false;
            Trigged = true;
        }

    }
}

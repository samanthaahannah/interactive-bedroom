using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationScript : MonoBehaviour
{
    Animator anim;
    bool Trigged;
    bool Closed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Trigged = false;
        Closed = true;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (Trigged == true)
        {

            if (Closed == false)
            {
                anim.SetBool("DoorClosed", false);
                Closed = true;
            }
            else if (Closed == true)
            {
                anim.SetBool("DoorClosed", true);
                Closed = false;
            }
        }
        else if (Trigged == false)
        {
            anim.SetTrigger("DoorTrig");
            Closed = false;
            Trigged = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopAnimationScript : MonoBehaviour
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
                anim.SetBool("LaptopClosed", false);
                Closed = true;
            }
            else if (Closed == true)
            {
                anim.SetBool("LaptopClosed", true);
                Closed = false;
            }
        }
        else if (Trigged == false)
        {
            anim.SetTrigger("LaptopTrig");
            Closed = false;
            Trigged = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAnimScript : MonoBehaviour
{
    Animator anim;
    [Header("Animation names")]
    public string[] anim_triggers = 
    { 
        "drawer1_trig", "drawer2_trig", "drawer3_trig", 
        "drawer4_trig", "drawer5_trig", "drawer6_trig" 
    };
    public string[] anim_bools = 
    { 
        "drawer1_closed", "drawer2_closed", "drawer3_closed", 
        "drawer4_closed", "drawer5_closed", "drawer6_closed" 
    };

    [Header("Which drawer? (0-5)")]
    public int drawer_index;

    bool trigged = false;
    bool closed = true;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        string trig = anim_triggers[drawer_index];
        string closed_bool = anim_bools[drawer_index];

        if (trigged)
        {
            anim.SetBool(closed_bool, closed);
            closed = !closed;
        }
        else
        {
            anim.SetTrigger(trig);
            closed = false;
            trigged = true;
        }
    }
}
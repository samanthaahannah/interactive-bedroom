using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAnimScript : MonoBehaviour
{
    Animator anim;
    [Header("Animation names")]
    public string[] animTriggers = 
    { 
        "Drawer1Trig", "Drawer2Trig", "Drawer3Trig", 
        "Drawer4Trig", "Drawer5Trig", "Drawer6Trig" 
    };
    public string[] animBools = 
    { 
        "Drawer1Closed", "Drawer2Closed", "Drawer3Closed", 
        "Drawer4Closed", "Drawer5Closed", "Drawer6Closed" 
    };

    [Header("Which drawer? (0-5)")]
    public int drawerIndex;

    bool Trigged = false;
    bool Closed = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        string trig = animTriggers[drawerIndex];
        string closedBool = animBools[drawerIndex];

        if (Trigged)
        {
            anim.SetBool(closedBool, false);
            Closed = !Closed;
        }
        else
        {
            anim.SetTrigger(trig);
            Closed = false;
            Trigged = true;
        }
    }
}
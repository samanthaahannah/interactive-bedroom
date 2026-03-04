using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    Light light_comp1;
    Light light_comp2;
    bool lights_on;

    void Start()
    {
        light_comp1 = light1.GetComponent<Light>();
        light_comp2 = light2.GetComponent<Light>();
        light1.SetActive(true);
        light2.SetActive(true);
        lights_on = true;
    }

    void OnMouseDown()
    {
        if (lights_on)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            lights_on = !lights_on;
        }
        else 
        {
            light1.SetActive(true);
            light2.SetActive(true);
            lights_on = true;
        }
        
    }
}

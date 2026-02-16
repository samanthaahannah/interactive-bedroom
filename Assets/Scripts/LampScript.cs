using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    Light lightComp1;
    Light lightComp2;
    bool LightsOn;
    // Start is called before the first frame update
    void Start()
    {
        lightComp1 = Light1.GetComponent<Light>();
        lightComp2 = Light2.GetComponent<Light>();
        Light1.SetActive(true);
        Light2.SetActive(true);
        LightsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (LightsOn == false )
        {
            Light1.SetActive(true);
            Light2.SetActive(true);
            LightsOn = true;
        }
        else if (LightsOn == true)
        {
            Light1.SetActive(false);
            Light2.SetActive(false);
            LightsOn = false;

        }

    }
}

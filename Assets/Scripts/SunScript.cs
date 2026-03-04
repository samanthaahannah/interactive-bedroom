using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunScript : MonoBehaviour
{
    public GameObject sun;
    public Button sun_button;
    public Button moon_button;

    private Light sun_comp;
    private bool is_night = true;

    void Start()
    {
        sun_comp = sun.GetComponent<Light>();
        sun_comp.intensity = 0.1f;
        sun_button.interactable = true;
        moon_button.interactable = false;
        RenderSettings.ambientLight = new Color(0.1707369f, 0.1707369f, 0.4150943f);
    }

    public void dayNight()
    {
        is_night = !is_night;
        if (is_night)
        {
            setNight();
        }
        else
        {
            setDay();
        }
    }

    private void setDay()
    {
        sun_comp.intensity = 1f;
        sun_button.interactable = false;
        moon_button.interactable = true;
        RenderSettings.ambientLight = new Color(0.5764329f, 0.5764329f, 0.8301887f);
    }

    private void setNight()
    {
        sun_comp.intensity = 0.1f;
        sun_button.interactable = true;
        moon_button.interactable = false;
        RenderSettings.ambientLight = new Color(0.1707369f, 0.1707369f, 0.4150943f);
    }
}

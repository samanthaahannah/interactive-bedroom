using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunScript : MonoBehaviour
{
    public GameObject Sun;
    public Button SunButton;
    public Button MoonButton;

    private Light SunComp;
    private bool IsNight = true;

    void Start()
    {
        SunComp = Sun.GetComponent<Light>();
        SunComp.intensity = 0.1f;
        SunButton.interactable = true;
        MoonButton.interactable = false;
        RenderSettings.ambientLight = new Color(0.1707369f, 0.1707369f, 0.4150943f);
    }

    public void DayNight()
    {
        IsNight = !IsNight;
        if (IsNight)
        {
            SetNight();
        }
        else
        {
            SetDay();
        }
    }

    private void SetDay()
    {
        SunComp.intensity = 1f;
        SunButton.interactable = false;
        MoonButton.interactable = true;
        RenderSettings.ambientLight = new Color(0.5764329f, 0.5764329f, 0.8301887f);
    }

    private void SetNight()
    {
        SunComp.intensity = 0.1f;
        SunButton.interactable = true;
        MoonButton.interactable = false;
        RenderSettings.ambientLight = new Color(0.1707369f, 0.1707369f, 0.4150943f);
    }
}

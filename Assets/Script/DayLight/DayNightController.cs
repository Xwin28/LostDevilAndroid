using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public Light sun;
    public float secondsInFullDay = 120f;
    [Range(0, 1)]
    public float currentTimeOfDay = 0;
    //[HideInInspector]
    public float timeMultiplier = 0.8f;

    float sunInitialIntensity;

    void Start()
    {
        currentTimeOfDay = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getCurrentTime();
        sunInitialIntensity = sun.intensity;
    }

    void Update()
    {
        UpdateSun();

        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

        if (currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);

        float intensityMultiplier = 1;
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            intensityMultiplier = 0;
        }
        else if (currentTimeOfDay <= 0.25f)
        {
            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.1f));
        }
        else if (currentTimeOfDay >= 0.73f)
        {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.1f)));
        }

        sun.intensity = sunInitialIntensity * (intensityMultiplier/2) + 0.1f;
    }

    public void SaveCurrenTime()
    {
        GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().setCurrentTime(currentTimeOfDay);
    }
}

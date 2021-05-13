using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolMusic : MonoBehaviour
{
    public AudioMixer mixer;
    public void SetLevel_music(float slidervalue)
    {
        mixer.SetFloat("MusicVol", slidervalue);
    }

    public void SetLevel_Vfx(float slidervalue)
    {
        mixer.SetFloat("SfxVol", slidervalue);
    }
}

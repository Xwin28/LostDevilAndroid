using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Ctrl_VolBegin : MonoBehaviour
{
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        float volMusic = objs.GetComponent<AllInfor>().getVolumeMusic();
        float volSfx = objs.GetComponent<AllInfor>().getVolumeSfx();
        mixer.SetFloat("MusicVol", volMusic);
        // chỉ chỉnh âm lương chưa chỉnh slider
        mixer.SetFloat("SfxVol", volSfx);

    }
}

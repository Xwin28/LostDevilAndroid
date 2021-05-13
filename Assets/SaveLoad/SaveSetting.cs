using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveSetting : MonoBehaviour
{
    public Slider music;
    public Slider sfx;
    public Dropdown Language;



    public void testdropdown()
    {
        Debug.LogError("Language == " + Language.value);
    }

    public void SaveSYSData()
    {

        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        objs.GetComponent<AllInfor>().setVolumeMusic(music.value);
        objs.GetComponent<AllInfor>().setVolumeSfx(sfx.value);
        int lang = Language.value;
        if (lang == 0)
        {
            objs.GetComponent<AllInfor>().setLanguage("En");
        }
        else if (lang == 1)
        {
            objs.GetComponent<AllInfor>().setLanguage("Vn");
        }
        objs.GetComponent<AllInfor>().Save();


    }
}

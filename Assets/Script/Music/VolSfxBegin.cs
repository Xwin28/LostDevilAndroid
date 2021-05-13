using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolSfxBegin : MonoBehaviour
{
    //CHinh Slider

    public Slider Volmusic;
    // Start is called before the first frame update
    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        Volmusic.value = objs.GetComponent<AllInfor>().getVolumeSfx();
    }

    private void OnEnable()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        Volmusic.value = objs.GetComponent<AllInfor>().getVolumeSfx();
    }
}

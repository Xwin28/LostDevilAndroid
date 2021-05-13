using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWebsitedd : MonoBehaviour
{
    public GameObject[] _adsPicture;
    private int i;
    public void OpenADSss()
    {
        {
            i = Random.Range(0, _adsPicture.Length);
            _adsPicture[i].SetActive(true);
        }
    }


    public void OpenWebs()
    {
        for( int k= 0;k<_adsPicture.Length;k++)
        {
            _adsPicture[k].SetActive(false);
        }
        switch(i)
        {
            case 0:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.XwinStudio.CubeJourney");
                break;
            case 1:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.XwinStudio.HeroesDashRun");
                break;
            case 2:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.XwinStudio.ShootingStar");
                break;
        }



    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnergyScript : MonoBehaviour
{
    public GameObject S_0,ParenEnergy;
    public GameObject S_2, S_3, S_4, S_5;
    public int _energy=5;

    public DateTime d1, d2, d3, d4, d5;

    private void Start()
    {
        AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        d1 = _all.getD1();
        d2 = _all.getD2();
        d3 = _all.getD3();
        d4 = _all.getD4();
        d5 = _all.getD5();
        _energy = _all.GetEnergy();
        ShowSlider();
    }
    public void TruEnergy()
    {
        if(_energy >0)
        {
            
            _energy  = _energy - 1;
           
            switch (_energy)
            {
                case 0:
                    d1 = d2;
                    d2 = d3;
                    d3 = d4;
                    d4 = d5;
                    d5 = System.DateTime.Now.AddMinutes(5);
                    break;
                case 1:
                    d2 = d3;
                    d3 = d4;
                    d4 = d5;
                    d5 = System.DateTime.Now.AddMinutes(5);
                    break;
                case 2:
                    d3 = d4;
                    d4 = d5;
                    d5 = System.DateTime.Now.AddMinutes(5);
                    break;
                case 3:
                    d4 = d5;
                    d5 = System.DateTime.Now.AddMinutes(5);
                    break;
                case 4:
                    d5 = System.DateTime.Now.AddMinutes(5);
                    break;
            }
            DateTime _next = System.DateTime.Now.AddMinutes(5);
            Debug.Log("NEXT Time = " + _next);
            ShowSlider();
        }
        
    }

    public void CongFullEnergy()
    {
        _energy = 5;
        ShowSliderAdd();
        d1=d2=d3=d4=d5= System.DateTime.Now;
        Saveinfor();
    }

    private void Update()
    {

        switch (_energy)
        {

            case 0:
                int _temp0 = DateTime.Compare(System.DateTime.Now, d1);
                if (_temp0 > 0)
                {
                    Debug.LogError("SHOE");
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                //fixes
                int _temp1t = DateTime.Compare(System.DateTime.Now, d2);
                if (_temp1t > 0)
                {

                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                //fixes
                int _temp2tt = DateTime.Compare(System.DateTime.Now, d3);
                if (_temp2tt > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                //fixes
                int _temp3ttt = DateTime.Compare(System.DateTime.Now, d4);
                if (_temp3ttt > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                // Fixes
                int _temp4tttt = DateTime.Compare(System.DateTime.Now, d5);
                if (_temp4tttt > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                break;
            case 1:
                int _temp1 = DateTime.Compare(System.DateTime.Now, d2);
                if (_temp1 > 0)
                {
                    Debug.LogError("SHOE");
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                //fixes
                int _temp2t = DateTime.Compare(System.DateTime.Now, d3);
                if (_temp2t > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                //fixes
                int _temp3tt = DateTime.Compare(System.DateTime.Now, d4);
                if (_temp3tt > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                // Fixes
                int _temp4ttt = DateTime.Compare(System.DateTime.Now, d5);
                if (_temp4ttt > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                break;
            case 2:
                int _temp2 = DateTime.Compare(System.DateTime.Now, d3);
                if (_temp2 > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                //fixes
                int _temp3t = DateTime.Compare(System.DateTime.Now, d4);
                if (_temp3t > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                // Fixes
                int _temp4tt = DateTime.Compare(System.DateTime.Now, d5);
                if (_temp4tt > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                break;
            case 3:
                int _temp3 = DateTime.Compare(System.DateTime.Now, d4);
                if (_temp3 > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                // Fixes
                int _temp4t = DateTime.Compare(System.DateTime.Now, d5);
                if (_temp4t > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                break;
            case 4:
                int _temp4 = DateTime.Compare(System.DateTime.Now, d5);
                if (_temp4 > 0)
                {
                    _energy = _energy + 1;
                    ShowSliderAdd();
                }
                break;

        }
    }


    public ChooseSFX _choose;
    public void ShowSliderAdd()
    {
        _choose.Choose_Sfx(11);
        ParenEnergy.SetActive(true);
        switch (_energy)
        {
            case 0:
                S_0.SetActive(false);
                S_2.SetActive(false);
                S_3.SetActive(false);
                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 1:
                S_0.SetActive(true);

                S_2.SetActive(false);
                S_3.SetActive(false);
                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 2:
                S_0.SetActive(true);
                S_2.SetActive(true);


                S_3.SetActive(false);
                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 3:
                S_0.SetActive(true);
                S_2.SetActive(true);
                S_3.SetActive(true);


                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 4:
                S_0.SetActive(true);
                S_2.SetActive(true);
                S_3.SetActive(true);
                S_4.SetActive(true);


                S_5.SetActive(false);

                break;
            case 5:
                S_0.SetActive(true);
                S_2.SetActive(true);
                S_3.SetActive(true);
                S_4.SetActive(true);
                S_5.SetActive(true);

                break;

        }

        StopCoroutine(delayhidenParenenergy());
        StartCoroutine(delayhidenParenenergy());
    }

    public void ShowSlider()
    {

        ParenEnergy.SetActive(true);
        switch (_energy)
        {
            case 0:
                S_0.SetActive(false);
                S_2.SetActive(false);
                S_3.SetActive(false);
                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 1:
                S_0.SetActive(true);

                S_2.SetActive(false);
                S_3.SetActive(false);
                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 2:
                S_0.SetActive(true);
                S_2.SetActive(true);


                S_3.SetActive(false);
                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 3:
                S_0.SetActive(true);
                S_2.SetActive(true);
                S_3.SetActive(true);


                S_4.SetActive(false);
                S_5.SetActive(false);

                break;
            case 4:
                S_0.SetActive(true);
                S_2.SetActive(true);
                S_3.SetActive(true);
                S_4.SetActive(true);


                S_5.SetActive(false);

                break;
            case 5:
                S_0.SetActive(true);
                S_2.SetActive(true);
                S_3.SetActive(true);
                S_4.SetActive(true);
                S_5.SetActive(true);
                
                break;

        }

        StopCoroutine(delayhidenParenenergy());
        StartCoroutine(delayhidenParenenergy());
    }


    IEnumerator delayhidenParenenergy()
    {
        yield return new WaitForSeconds(2);
        ParenEnergy.SetActive(false);
    }
    public void Saveinfor()
    {
        AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        _all.setD1(this.d1);
        _all.setD2(this.d2);
        _all.setD3(this.d3);
        _all.setD4(this.d4);
        _all.setD5(this.d5);
        _all.SetEnergy(this._energy);
        _all.Save();
    }
}

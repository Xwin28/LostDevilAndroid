using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    public GameObject obj;
    public GameObject M_obj;
    public GameObject _Cavas;
    public ChooseSFX _choose;
    public GoogleAchiement _Achiement;
    private Collider _col;
    private void Start()
    {
        _col = gameObject.GetComponent<Collider>();
        bool _check = false;
        GameObject _all = GameObject.FindGameObjectWithTag("DATA");
        bool[] _temp = _all.GetComponent<AllInfor>().getAllPhong1();
        for( int i = 0;i<_temp.Length;i++)
        {
            if (_temp[i] == false)
            {
                _check = true;
            }
        }


        if(_check == false)
        {
            Destroy(M_obj);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _col.enabled = false;
            _choose.Choose_Sfx();

            AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
            bool[] _temp = _all.Phong_1;
            int number = 0;
            for( int i =0;i<187; i++)
            {
                if(_temp[i] == true)
                {
                    number = number + 1;
                }
            }

            if(number >= 50 && _all.GetA5() == false)
            {
                _all.setA5(true);
                _Achiement.UnlockAchiement(5);
            }
            else if(number >= 185 && _all.GetA0() == false)
            {
                _all.setA0(true);
                _Achiement.UnlockAchiement(0);
            }

            Take_P1();
            obj.SetActive(false);
            StartCoroutine(ShowCavas());
        }
    }


    IEnumerator ShowCavas()
    {
        _Cavas.SetActive(false);
        _Cavas.SetActive(true);
        yield return new WaitForSeconds(2);
        _Cavas.SetActive(false);
        Destroy(M_obj);
    }

    //Không Save vì để cuối màn ms Save
    public void Take_P1()
    {
        GameObject _all = GameObject.FindGameObjectWithTag("DATA");
        bool[] _temp = _all.GetComponent<AllInfor>().getAllPhong1();
        int x = 0;
        do
        {
            x = UnityEngine.Random.Range(0, _temp.Length);
        }
        while (_temp[x] == true);
        _all.GetComponent<AllInfor>().SetPhong_1(x, true);
        Debug.Log("Phong = " + _all.GetComponent<AllInfor>().getPhong_1(x));
    }


}

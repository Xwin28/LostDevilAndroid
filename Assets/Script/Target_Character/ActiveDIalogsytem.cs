using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDIalogsytem : MonoBehaviour
{
    public int _indexSuccess, _indexFail;
    public ChooseSFX _SFX;
    public GameObject _dialofsys;
    public void ActiveDialog()
    {
        AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        if (_all.getCoin() >= 100)
        {
            //Tru coin
            _dialofsys.SetActive(true);

            //Show UI buton Run
        }
        else
        {
            _SFX.Choose_Sfx(_indexFail);
        }

    }


}

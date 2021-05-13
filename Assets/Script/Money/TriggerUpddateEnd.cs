using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUpddateEnd : MonoBehaviour
{
    public int _indexSuccess, _indexFail;
    public ChooseSFX _SFX;
    public DialogueManager _dialogueManager;
    bool doOne= true, doOne1= true;
    public void UpgradeBuy(int a)
    {
        
            if (_dialogueManager.Now_position == a)
            {
            if (doOne)
            {
                doOne = false;
                AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
                if (_all.getCoin() >= 100)
                {
                    //Tru coin
                    int _tempCoin = _all.getCoin();
                    _all.setCoin(_tempCoin - 100);
                    _SFX.Choose_Sfx(_indexSuccess);
                    _all.Save();

                    //Show UI buton Run
                }
                else
                {
                    _SFX.Choose_Sfx(_indexFail);
                }
            }
        }
        

    }

    public void EndB(int b)
    {

            if (_dialogueManager.Now_position == b)
            {
            if (doOne1)
            {
                doOne1 = false;
                AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
                if (_all.getCoin() >= 100)
                {
                    //Tru coin
                    int _tempCoin = _all.getCoin();
                    _all.setCoin(_tempCoin - 100);
                    _SFX.Choose_Sfx(_indexSuccess);
                    _all.Save();

                    //Show UI buton Run
                }
                else
                {
                    _SFX.Choose_Sfx(_indexFail);
                }
            }
        }

    }


}

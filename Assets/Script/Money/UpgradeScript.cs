using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{
    public int _indexSuccess, _indexFail;
    public ChooseSFX _SFX;
    public UICostScript _cost;
    public void UpgradeBuy()
    {
        AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        if (!_all.isCanRun()
            && !_all.isCanJump()
            && !_all.isCanFly())
        {
            if (_all.getCoin() >= 5)
            {
                //Tru coin
                int _tempCoin = _all.getCoin();
                _all.setCoin(_tempCoin - 5);
                _SFX.Choose_Sfx(_indexSuccess);
                _all.setCanRun(true);
                _all.Save();
                ShowUISkill();
                //Show UI buton Run
            }
            else
            {
                _SFX.Choose_Sfx(_indexFail);
            }
        }
        //Upgrade Jump
        else if (_all.isCanRun()
           && !_all.isCanJump()
           && !_all.isCanFly())
        {
            if (_all.getCoin() >= 5)
            {
                int _tempCoin1 = _all.getCoin();
                _all.setCoin(_tempCoin1 - 5);
                _SFX.Choose_Sfx(_indexSuccess);
                _all.setCanJump(true);
                _all.Save();
                ShowUISkill();
                //Show UI buton Jump
            }
            else
            {
                _SFX.Choose_Sfx(_indexFail);
            }
        }
        //Upgrade Fly
        else if (_all.isCanRun()
           && _all.isCanJump()
           && !_all.isCanFly())
        {
            if (_all.getCoin() >= 5)
            {
                int _tempCoin2 = _all.getCoin();
                _all.setCoin(_tempCoin2 - 5);
                _SFX.Choose_Sfx(_indexSuccess);
                _all.setCanFly(true);
                _all.Save();
                ShowUISkill();
                //Show UI buton Fly
            }
            else
            {
                _SFX.Choose_Sfx(_indexFail);
            }
        }

        else
        {
            _SFX.Choose_Sfx(_indexFail);
        }
    }


    public void ShowUISkill()
    {
        SkillScript _skill = GameObject.FindGameObjectWithTag("Player").GetComponent<SkillScript>();
        _skill.Check();
        _cost.ResetShow();
    }
}

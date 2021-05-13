using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_2_Script : MonoBehaviour
{
    public Text _text;
    public DialogueManager _dialogueManager;
    public GameObject _VFX,_VFX1;
    public ChooseSFX _SFX;
    public LoadingScreenScript _load;
    public GoogleAchiement _achiement;
    public void Choose_2()
    {
        int _Next_Position = _dialogueManager._c2[_dialogueManager.Now_position];
        if(_Next_Position < _dialogueManager._c2.Length)
        {
            if (_Next_Position != 0)
                _dialogueManager.DisplaySentence(_Next_Position);
        }

    }

    public GameObject _ghost;
    public void ShowGhost(int i)
    {
        _ghost.SetActive(true);
    }

    bool doOne = true;

    public void ENDGameB(int b)
    {

        


            if (_dialogueManager.Now_position == b)
            {
            if (doOne)
            {
                AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
                if (_all.GetA1() == false)
                {
                    _all.setA1(true);
                    _achiement.UnlockAchiement(1);
                    _all.Save();
                }

                doOne = false;
                GameObject _player = GameObject.FindGameObjectWithTag("Player");
                _player.GetComponent<Animator>().SetBool("Death", true);
                _SFX.S_Choose_Sfx(26);
                Instantiate(_VFX1, _player.transform.position, _player.transform.rotation);
                
                StartCoroutine(delayOpenlv());
            }
        }



    }



    public string _level = "FinalBoss";
    IEnumerator delayOpenlv()
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player");
        yield return new WaitForSeconds(2.5f);
        _SFX.S_Choose_Sfx(27);
        Instantiate(_VFX, _player.transform.position, _player.transform.rotation);
        yield return new WaitForSeconds(1);
        _load.LoadLevel(_level);
    }
}

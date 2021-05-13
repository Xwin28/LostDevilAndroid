using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class Btn_1_Script : MonoBehaviour
{
    public Text _text;
    public DialogueManager _dialogueManager;
    public GameObject _VFX, _VFX1;
    public ChooseSFX _SFX;
    public LoadingScreenScript _load;
    public GoogleAchiement _achiement;
    public void Choose_1()
    {
        
        int _Next_Position =_dialogueManager._c1[_dialogueManager.Now_position];
        if(_Next_Position < _dialogueManager._c1.Length)
        {
            if (_Next_Position != 0)
                _dialogueManager.DisplaySentence(_Next_Position);
        }

    }

    bool doOne = true;
    public void Openlv(int a)
    {

            if (_dialogueManager.Now_position == a)
            {
            if (doOne)
            {
                doOne = false;
                SceneManager.LoadScene("testLV");
            }
        }


    }

    public GameObject _UIFailUpgrade;
    public GameObject _UIEndGame;
    public void ENDGame(int a)
    {
        
        if (_dialogueManager.Now_position == a)
        {

            GameObject _player = GameObject.FindGameObjectWithTag("Player");
            _player.GetComponent<BasicBehaviour>().enabled = false;
            _player.GetComponent<MoveBehaviour>().enabled = false;
            _player.GetComponent<FlyBehaviour>().enabled = false;
            _player.GetComponent<Animator>().SetBool("Death", true);
            Instantiate(_VFX1, _player.transform.position, _player.transform.rotation);
            _SFX.S_Choose_Sfx(26);
            _UIFailUpgrade.SetActive(true);

            AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
            if(_all.GetA4() == false)
            {
                _all.setA4(true);
                _achiement.UnlockAchiement(4);
                _all.Save();
            }


            StartCoroutine(delayOpenEndGame());
        }


    }


    IEnumerator delayOpenEndGame()
    {
        yield return new WaitForSeconds(3);
        _UIEndGame.SetActive(true);
    }

    public void btnEND()
    {
        StartCoroutine(delayOpenlv());
    }


    public string _level = "MainHouse";
    IEnumerator delayOpenlv()
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player");
        yield return new WaitForSeconds(1.5f);
        _SFX.S_Choose_Sfx(27);
        Instantiate(_VFX, _player.transform.position, _player.transform.rotation);
        yield return new WaitForSeconds(1);
        _load.LoadLevel(_level);
    }
}

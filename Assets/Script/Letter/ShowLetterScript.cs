using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLetterScript : MonoBehaviour
{

    public GameObject _buttonShow, Letter;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _buttonShow.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _buttonShow.SetActive(false);
        }
    }

    public void Showletter()
    {
        _buttonShow.SetActive(false);
        Letter.SetActive(true);
    }
}

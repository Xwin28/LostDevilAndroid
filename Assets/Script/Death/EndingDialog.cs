using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingDialog : MonoBehaviour
{
    public GameObject _ShowOBJ;
    public float _timeDelay;
    public void ShowOBJ()
    {
        StartCoroutine(DelayShowOBJ());
    }

    IEnumerator DelayShowOBJ()
    {
        
        yield return new WaitForSeconds(_timeDelay);
        

        _ShowOBJ.SetActive(true);
    }
}

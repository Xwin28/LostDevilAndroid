using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UICoinScropt : MonoBehaviour
{

    private AllInfor _all;
    private Text _txt;
    private void Start()
    {
        _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        _txt = gameObject.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        _txt.text = _all.getCoin().ToString();
    }
}

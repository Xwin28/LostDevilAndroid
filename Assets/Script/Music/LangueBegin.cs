using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangueBegin : MonoBehaviour
{
    public Dropdown lang;
    // Start is called before the first frame update
    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        string temp = objs.GetComponent<AllInfor>().getLanguage();
        if (temp.Equals("En"))
        {
            lang.value = 0;
        }
        else if (temp.Equals("Vn"))
        {
            lang.value = 1;
        }

    }

    private void OnEnable()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        string temp = objs.GetComponent<AllInfor>().getLanguage();
        if (temp.Equals("En"))
        {
            lang.value = 0;
        }
        else if (temp.Equals("Vn"))
        {
            lang.value = 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VampireDialog : MonoBehaviour
{
    public string []TextId;

    // Use this for initialization
    void Start()
    {
        int i = Random.Range(0, TextId.Length);


        var text = GetComponent<Text>();
        if (text != null)
            if (TextId[i] == "ISOCode")
                text.text = I18n.GetLanguage();
            else
                text.text = I18n.Fields[TextId[i]];

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UICostScript : MonoBehaviour
{
    private Text txt;
    //Kiểm tra xem tốn bao nhiêu để nâng cấp
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "5";


    }

    public void ResetShow()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "5";
        

    }
}

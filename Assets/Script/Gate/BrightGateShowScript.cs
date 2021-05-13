using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightGateShowScript : MonoBehaviour
{
    public int SceneHell;


    // Start is called before the first frame update
    void Start()
    {
        bool _temp = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getSceneHell(SceneHell);
        if (_temp)
        {
            gameObject.SetActive(true);
        }
        else
            gameObject.SetActive(false);
    }
   
}

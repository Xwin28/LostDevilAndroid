using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallLevelLoadScript : MonoBehaviour
{
    public string Scene;
    public GameObject _parent;
    public void LoadScene()
    {
        StopAllCoroutines();
        Time.timeScale = 1;
        GameObject _levelLoad = GameObject.FindGameObjectWithTag("LevelLoad");
        _levelLoad.GetComponent<LoadingScreenScript>().LoadLevel(Scene);
        _parent.SetActive(false);
    }
}

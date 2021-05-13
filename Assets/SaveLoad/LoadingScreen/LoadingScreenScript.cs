using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreenScript : MonoBehaviour
{
    public Animator anim;
    public float tranTime = 0.5f;
    public string SceneName;


    private void Start()
    {
        //LoadLevel();
    }

    public void LoadLevel()
    {
        Time.timeScale = 1;
        anim.SetTrigger("Start");
        StartCoroutine(load());
    }

    IEnumerator load()
    {
        yield return new WaitForSeconds(tranTime);
        SceneManager.LoadScene(SceneName);
    }

    public void LoadLevel(string lvName)
    {
        Time.timeScale = 1;
        StartCoroutine(load(lvName));
    }

    IEnumerator load(string lvName)
    {
        Time.timeScale = 1;
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(tranTime);
        SceneManager.LoadScene(lvName);
    }
}

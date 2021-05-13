using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateScript : MonoBehaviour
{
    public GameObject hiddenObject;
    public GameObject ShowPar;
    public int SceneHell;
    public Collider _col;

    // Start is called before the first frame update
    void Start()
    {
        bool _temp = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getSceneHell(SceneHell);
        if(_temp)
        {
            Des();
        }
    }
    public ChooseSFX _SFX;
    public void Des()
    {
        _SFX.Choose_Sfx(14);
        _col.enabled = false;
        hiddenObject.SetActive(false);
        ShowPar.SetActive(true);
        StartCoroutine(delayDes());
    }


    IEnumerator delayDes()
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
}

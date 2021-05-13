using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ControlVFX_1 : MonoBehaviour
{
    public GameObject _this;
    public VisualEffect _vfx;
    public ChooseSFX _SFX;
    float i;
    bool run = true;
    private void Start()
    {
        i = Random.Range(0.7f, 1.5f);
        tt(i);
    }

    public int _TimetoDestroy;
    IEnumerator delayDESTOY()
    {
        yield return new WaitForSeconds(_TimetoDestroy);
        Destroy(_this);
    }

    IEnumerator delaySFX(float i)
    {
        yield return new WaitForSeconds(i+2);
        run = true;
        _SFX.Choose_Sfx();
    }


    IEnumerator delaySFXfrist(float i)
    {
        yield return new WaitForSeconds(i);
        run = true;
        _SFX.Choose_Sfx();
    }

    public void tt(float i)
    {
        
        _vfx.SetFloat("LifeTime", i);
    }

    bool doOne = true;
    private void Update()
    {
        if(doOne)
        {
            doOne = false;
            StartCoroutine(delaySFXfrist(i));
        }
        else if(run)
        {
            run = false;
            StartCoroutine(delaySFX(i));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class StoneShootDES : MonoBehaviour
{
    public GameObject _parent;
    public float delayTime;
    public GameObject _VFX;
    public ChooseSFX _SFX;
    public void DestroyThisStone()
    {

        StartCoroutine(DelayDestroy());
    }

    IEnumerator DelayDestroy()
    {
        Destroy(_parent);
        yield return new WaitForSeconds(delayTime);

        Instantiate(_VFX, gameObject.transform.position, new Quaternion(0,0,0,0));
        _SFX.Choose_Sfx();
        Destroy(this.gameObject);
    }
}

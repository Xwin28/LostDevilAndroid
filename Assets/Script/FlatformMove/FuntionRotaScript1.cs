using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class FuntionRotaScript1 : MonoBehaviour
{

    public ChooseSFX _choose;
    public RotationFlatformScript[] _RotateOBJ;
    public Animator _anim;
    public void RunRotate()
    {
        for (int i = 0; i < _RotateOBJ.Length; i++)
        {
            _RotateOBJ[i]._Upgrade = true;

        }
        _choose.Choose_Sfx();
        _anim.SetBool("On", true);
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TiggerRotaScript : MonoBehaviour
{
    public GameObject _DesParrent;
    public ChooseSFX _choose;
    public RotationFlatformScript[] _RotateOBJ;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for(int i= 0;i< _RotateOBJ.Length;i++)
            {
                _RotateOBJ[i]._Upgrade = true;
                
            }
            _choose.Choose_Sfx();
            Destroy(_DesParrent);
        }
    }



}

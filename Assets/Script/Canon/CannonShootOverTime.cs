using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShootOverTime : MonoBehaviour
{
    public GameObject _bullet;
    public ChooseSFX _SFX;
    public bool _shoot;


    private void Start()
    {
        StartCoroutine(delayShoot());
    }
    private void Update()
    {
        if(_shoot)
        {
            _shoot = false;
            Instantiate(_bullet, gameObject.transform.position, gameObject.transform.rotation);
            _SFX.Choose_Sfx();
            StartCoroutine(delayShoot());
        }
    }

    IEnumerator delayShoot()
    {
        yield return new WaitForSeconds(5);
        _shoot = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShootScript : MonoBehaviour
{
    public GameObject _bullet;
    public ChooseSFX _SFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("HitFall");
            Instantiate(_bullet, gameObject.transform.position, gameObject.transform.rotation);
            _SFX.Choose_Sfx();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeathColliScript : MonoBehaviour
{
    public GameObject _bullet;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("HitFall");
            Instantiate(_bullet, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}

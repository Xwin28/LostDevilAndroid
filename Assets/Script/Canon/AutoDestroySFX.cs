using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroySFX : MonoBehaviour
{
    public float TimetoDelay;
    public bool _isDestroy;
    // Start is called before the first frame update
    void Start()
    {
        if(_isDestroy)
        {
            StartCoroutine(delayDestroy());
        }
    }


    IEnumerator delayDestroy()
    {
        yield return new WaitForSeconds(TimetoDelay);
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLapCharacterScript : MonoBehaviour
{
    public BasicBehaviour _basicScript;
    public bool _key;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("KillPlayer"))
        {
            PlayDead();
        }
    }

    public void PlayDead()
    {
        _basicScript._alive = false;
        //Play animation Dead
    }
}

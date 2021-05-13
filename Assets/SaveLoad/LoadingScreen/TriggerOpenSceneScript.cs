using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenSceneScript : MonoBehaviour
{
    public LoadingScreenScript load;
    public string level;
    public ChooseSFX _choose;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _choose.Choose_Sfx();
            Time.timeScale = 1;
            load.LoadLevel(level);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUpgrade : MonoBehaviour
{

   public GameObject _update;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            _update.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
 
            _update.SetActive(false);
        }
    }
}

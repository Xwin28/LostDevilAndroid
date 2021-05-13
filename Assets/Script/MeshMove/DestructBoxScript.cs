using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructBoxScript : MonoBehaviour
{
    public GameObject HiddenBox;
    public GameObject _partiShow;
    public Collider _col;
    public ChooseSFX _choose;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Des"))
        {
            _col.enabled = false;
            HiddenBox.SetActive(false);
            _partiShow.SetActive(true);
            //_col.isTrigger = true;
            StartCoroutine(delayDes());
        }    
        else if(other.gameObject.CompareTag("KillPlayer"))
        {
            _col.enabled = false;
            HiddenBox.SetActive(false);
            _partiShow.SetActive(true);
            //_col.isTrigger = true;
            StartCoroutine(delayKillPlayer(other.gameObject));

        }
    }

    IEnumerator delayKillPlayer(GameObject col)
    {
        _choose.Choose_Sfx();
        Destroy(col);
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }

    IEnumerator delayDes()
    {
        _choose.Choose_Sfx();
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
}

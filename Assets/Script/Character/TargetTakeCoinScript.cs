using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTakeCoinScript : MonoBehaviour
{

    Collider _col;

    private void Start()
    {
        _col = gameObject.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _col.enabled = false;
            
            int _tempCoin = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getCoin();
            GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().setCoin(_tempCoin +1);
            GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().SetSceneHellDone(_SceneDone, true);
            GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().SetSceneHell(_SceneDone + 1, true);
            GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().Save();
            StartCoroutine(ShowCavas());

        }
    }

    public LoadingScreenScript _load;
    public string _Scene;
    // Scene Wall > Scene Done 1
    public int _SceneDone;
    IEnumerator DelayLoad()
    {
        yield return new WaitForSeconds(4);
        _load.LoadLevel(_Scene);
    }

    public GameObject obj;
    public GameObject _Cavas;
    IEnumerator ShowCavas()
    {
        obj.SetActive(false);
        _Cavas.SetActive(false);
        _Cavas.SetActive(true);
        yield return new WaitForSeconds(2);
        _Cavas.SetActive(false);
    }
}

using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTake : MonoBehaviour
{
 
    Collider _col;
    LoadingScreenScript _load;
    public ChooseSFX _SFX;
    private void Start()
    {
        _load = GameObject.FindGameObjectWithTag("LevelLoad").GetComponent<LoadingScreenScript>();
        _col = gameObject.GetComponent<Collider>();
    }
    bool doOne = false;
    private void OnTriggerEnter(Collider other)
    {
        
           // if (other.gameObject.CompareTag("Player"))
          //  {
            if (doOne == false)
            {

                _SFX.S_Choose_Sfx(13);
                doOne = true;

                Debug.Log("COLAP");
                _col.enabled = false;
                Time.timeScale = 0;
                int _tempCoin = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getCoin();
                GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().setCoin(_tempCoin + 100);
                GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().SetSceneHellDone(_SceneDone, true);
                GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().SetSceneHell(_SceneDone + 1, true);
                GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().Save();
                StartCoroutine(ShowCavas());

            }
       // }
    }


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

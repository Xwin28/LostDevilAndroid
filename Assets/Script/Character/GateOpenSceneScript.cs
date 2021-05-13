using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpenSceneScript : MonoBehaviour
{
    public int SceneHell;
    public LoadingScreenScript load;
    public string level;
    public GameObject _obj;
    public ChooseSFX _choose;
    // Start is called before the first frame update
    void Start()
    {
        bool _temp = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getSceneHellDone(SceneHell);
        if (_temp)
        {
            Destroy(_obj);
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int i = other.gameObject.GetComponent<EnergyScript>()._energy;
            if(i>0)
            {
                _choose.Choose_Sfx();
                other.gameObject.GetComponent<EnergyScript>().TruEnergy();
                other.gameObject.GetComponent<EnergyScript>().Saveinfor();
                load.LoadLevel(level);
            }

        }
    }
}

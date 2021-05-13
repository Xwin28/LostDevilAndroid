using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfHoiEnergy : MonoBehaviour
{
    public GameObject _SpriteEnergy;
    public Collider _col;
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getSceneHellDone(19) == true)
        {
            _SpriteEnergy.SetActive(false);
            _col.enabled = false;
        }
    }
    public void PlusEnergy_SelfADS()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<EnergyScript>().CongFullEnergy();
        GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().SetSceneHellDone(19, true);
    }
}

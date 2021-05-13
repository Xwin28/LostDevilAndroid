using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoiNangLuong : MonoBehaviour
{
    public void PlusEnergy_SelfADS()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<EnergyScript>().CongFullEnergy();
    }

    public void PlusEnergy()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<EnergyScript>().CongFullEnergy();
    }
}

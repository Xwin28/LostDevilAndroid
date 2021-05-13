using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenGateFromHouse : MonoBehaviour
{
    public ChooseSFX _choose;
    public LoadingScreenScript load;
    public DayNightController _DayNight;
    public string level;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int i = other.gameObject.GetComponent<EnergyScript>()._energy;

            if (i >= 2)
            {
               
                other.gameObject.GetComponent<EnergyScript>().TruEnergy();
                other.gameObject.GetComponent<EnergyScript>().TruEnergy();

                other.gameObject.GetComponent<EnergyScript>().Saveinfor();


                _choose.Choose_Sfx();
                Time.timeScale = 1;
                GameObject all = GameObject.FindGameObjectWithTag("DATA");
                _DayNight.SaveCurrenTime();
                all.GetComponent<AllInfor>().Save();

                load.LoadLevel(level);
            }


        }


        
       
    }
}

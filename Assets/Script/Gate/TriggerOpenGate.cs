using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenGate : MonoBehaviour
{
    public int Gate;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
            switch(Gate)
            {
                case 1:
                    _all.Set_LGate1(true);
                    break;
                case 2:
                    _all.Set_LGate2(true); break;
                case 3:
                    _all.Set_LGate3(true); break;
            }
            _all.Save();
            
        }
    }
}

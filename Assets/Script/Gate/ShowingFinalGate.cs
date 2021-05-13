using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingFinalGate : MonoBehaviour
{
    public AudioPlayer _au;
    public GameObject laze_1, laze_2, laze_3, finalGate;
    // Start is called before the first frame update
    void Start()
    {
        AllInfor all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        

                if(all.get_LGate1())
                {
            _au.S_Playsfx(0);
            _au.Playmusic(1);
                    laze_1.SetActive(true);
                }
                else
                {
                    laze_1.SetActive(false);
                }


                if (all.get_LGate2())
                {
                    laze_2.SetActive(true);
                }
                else
                {
                    laze_2.SetActive(false);
                }


                if (all.get_LGate3())
                {
                    laze_3.SetActive(true);
                    finalGate.SetActive(true);
                }
                else
                {
                    laze_3.SetActive(false);
                    finalGate.SetActive(false);
                }


    }

}

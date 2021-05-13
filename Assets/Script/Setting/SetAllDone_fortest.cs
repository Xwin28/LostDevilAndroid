using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAllDone_fortest : MonoBehaviour
{
    public void SETALL()
    {
        AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        /*        public bool[] Phong_1 = new bool[187];
            public bool[] SceneHell = new bool[20];
            public bool[] SceneHellDone = new bool[20];*/
        bool[] _scene = _all.SceneHell;
        bool[] _scenDonee = _all.SceneHellDone;
        for( int i=0;i<15;i++)
        {
            _all.SetSceneHell(i, true);
            _all.SetSceneHellDone(i, true);
        }
        _all.Set_LGate1(true);
        _all.Set_LGate2(true);
        _all.Set_LGate3(true);
        /*_all.setCanRun(true);
        _all.setCanJump(true);
        _all.setCanFly(true);*/
        _all.setCoin(500);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Collections.LowLevel.Unsafe;

[System.Serializable]

public class InforDATA
{
    public float VolumeMusic = 1;
    public float VolumeSfx = 1;
    public int Music = 0; // pick music in array
    public string Language = "En";
    public int coin;
    public int coinpersecond;

    [Header("HOUSE")]
    public bool[] Phong_1 = new bool[187];
    public bool[] SceneHell = new bool[20];
    public bool[] SceneHellDone = new bool[20];

    public bool CanRun, CanJump, CanFly;
    public DateTime d1, d2, d3, d4, d5;
    public int _Energy;




    public bool _LGate_1, _LGate_2, _LGate_3;
    public float currentTime;
    public bool a0, a1, a2, a3, a4, a5, a6;// archiment
    public bool ENDGAME;

    public InforDATA()
    {
        //System Infor
        VolumeMusic = 1;
        VolumeSfx = 1;
        Music = 0; // pick music in array
        Language = "En";
        //COIN
        coin = 0;
        coinpersecond = 0;


        d1 = System.DateTime.Now;
        d2 = System.DateTime.Now;
        d3 = System.DateTime.Now;
        d4 = System.DateTime.Now;
        d5 = System.DateTime.Now;
        _Energy = 5;
        _LGate_1 = false;
        _LGate_2 = false;
        _LGate_3 = false;

        a0 = false;
        a1 = false;
        a2 = false;
        a3 = false;
        a4 = false;
        a5 = false;
        a6 = false;
        ENDGAME = false;
        currentTime = 0;
        //Do các mảng bằng nhau nên for 1 lần
        for ( int i = 0; i<Phong_1.Length;i++)
        {
            Phong_1[i] = false;
        }



        SceneHell[0] = true;
        for ( int i=1;i< SceneHell.Length; i++)
        {
            SceneHell[i] = false;
        }

        for (int i = 0; i < SceneHellDone.Length; i++)
        {
            SceneHellDone[i] = false;
        }


    }

    public InforDATA(AllInfor _allInfor)
    {
        //System Infor
        VolumeMusic = _allInfor.VolumeMusic;
        VolumeSfx = _allInfor.VolumeSfx;
        Music = _allInfor.Music; // pick music in array
        Language = _allInfor.Language;
        //COIN
        coin = _allInfor.coin;
        coinpersecond = _allInfor.coinpersecond;

        Phong_1 = _allInfor.Phong_1;

        SceneHell = _allInfor.SceneHell;
        SceneHellDone = _allInfor.SceneHellDone;
        CanRun = _allInfor.CanRun;
        CanJump = _allInfor.CanJump;
        CanFly = _allInfor.CanFly;
        this.d1 = _allInfor.d1;
        this.d2 = _allInfor.d2;
        this.d3 = _allInfor.d3;
        this.d4 = _allInfor.d4;
        this.d5 = _allInfor.d5;
        this._Energy = _allInfor._Energy;

        this._LGate_1 = _allInfor._LGate_1;
        this._LGate_2 = _allInfor._LGate_2;
        this._LGate_3 = _allInfor._LGate_3;
        this.currentTime = _allInfor.currentTime;

        this.a0 = _allInfor.GetA0();
        this.a1 = _allInfor.GetA1();
        this.a2 = _allInfor.GetA2();
        this.a3 = _allInfor.GetA3();
        this.a4 = _allInfor.GetA4();
        this.a5 = _allInfor.GetA5();
        this.a6 = _allInfor.GetA6();

        this.ENDGAME = _allInfor.GetEndGame();
    }
}

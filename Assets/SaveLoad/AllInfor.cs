using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class AllInfor : MonoBehaviour
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


    private bool ENDGAME;
    public bool _LGate_1, _LGate_2, _LGate_3;
    public float currentTime;
    private bool a0, a1, a2, a3, a4, a5, a6;// archiment

    #region getset Block
    ///GET SET
    ///

    public bool GetEndGame()
    {
        return ENDGAME;
    }

    public void setEndGame(bool value)
    {
        this.ENDGAME = value;
    }

    public bool GetA0()
    {
        return a0;
    }

    public bool GetA1()
    {
        return a1;
    }

    public bool GetA2()
    {
        return a2;
    }

    public bool GetA3()
    {
        return a3;
    }

    public bool GetA4()
    {
        return a4;
    }

    public bool GetA5()
    {
        return a5;
    }

    public bool GetA6()
    {
        return a6;
    }

    public void setA0(bool a0)
    {
        this.a0 = a0;
    }

    public void setA1(bool a1)
    {
        this.a1 = a1;
    }

    public void setA2(bool a2)
    {
        this.a2 = a2;
    }

    public void setA3(bool a3)
    {
        this.a3 = a3;
    }

    public void setA4(bool a4)
    {
        this.a4 = a4;
    }

    public void setA5(bool a5)
    {
        this.a5 = a5;
    }

    public void setA6(bool a6)
    {
        this.a6 = a6;
    }






    public void setCurrentTime(float value)
    {
        this.currentTime = value;
    }

    public float getCurrentTime()
    {
        return this.currentTime;
    }

    //

    public void Set_LGate1(bool value)
    {
        this._LGate_1 = value;
    }

    public bool get_LGate1()
    {
        return _LGate_1;
    }

    public void Set_LGate2(bool value)
    {
        this._LGate_2 = value;
    }

    public bool get_LGate2()
    {
        return _LGate_2;
    }

    public void Set_LGate3(bool value)
    {
        this._LGate_3 = value;
    }

    public bool get_LGate3()
    {
        return _LGate_3;
    }
    //
    public void SetEnergy(int _energy)
    {
        this._Energy = _energy;
    }

    public int GetEnergy()
    {
        return _Energy;
    }

    public void setD1(DateTime d1)
    {
        this.d1 = d1;
    }

    public void setD2(DateTime d2)
    {
        this.d2 = d2;
    }

    public void setD3(DateTime d3)
    {
        this.d3 = d3;
    }

    public void setD4(DateTime d4)
    {
        this.d4 = d4;
    }

    public void setD5(DateTime d5)
    {
        this.d5 = d5;
    }

    public DateTime getD1()
    {
        return d1;
    }

    public DateTime getD2()
    {
        return d2;
    }

    public DateTime getD3()
    {
        return d3;
    }

    public DateTime getD4()
    {
        return d4;
    }

    public DateTime getD5()
    {
        return d5;
    }
    ///


    public void setCanRun(bool CanRun)
    {
        this.CanRun = CanRun;
    }

    public void setCanJump(bool CanJump)
    {
        this.CanJump = CanJump;
    }

    public void setCanFly(bool CanFly)
    {
        this.CanFly = CanFly;
    }

    public bool isCanRun()
    {
        return CanRun;
    }

    public bool isCanJump()
    {
        return CanJump;
    }

    public bool isCanFly()
    {
        return CanFly;
    }


    //GetPhong



    public bool[] getAllPhong1()
    {
        return Phong_1;
    }

    public bool getSceneHellDone(int i)
    {
        return SceneHellDone[i];
    }
    public bool getSceneHell(int i)
    {
        return SceneHell[i];
    }

    public bool getPhong_1(int i)
    {
        return Phong_1[i];
    }



    //GetPhong




    //SET PHONG

    public void SetSceneHellDone(int i, bool value)
    {
        SceneHellDone[i] = value;
    }
    public void SetSceneHell(int i, bool value)
    {
        SceneHell[i] = value;
    }

    public void SetPhong_1(int i, bool value)
    {
        Phong_1[i] = value;
    }



   
    //SET PHONG


    public void setVolumeMusic(float VolumeMusic)
    {
        this.VolumeMusic = VolumeMusic;
    }

    public void setVolumeSfx(float VolumeSfx)
    {
        this.VolumeSfx = VolumeSfx;
    }

    public void setMusic(int Music)
    {
        this.Music = Music;
    }

    public void setLanguage(string language)
    {
        this.Language = language;
    }

    public void setCoin(int coin)
    {
        this.coin = coin;
    }

    public void setCoinpersecond(int coinpersecond)
    {
        this.coinpersecond = coinpersecond;
    }


    public float getVolumeMusic()
    {
        return VolumeMusic;
    }

    public float getVolumeSfx()
    {
        return VolumeSfx;
    }

    public int getMusic()
    {
        return Music;
    }

    public string getLanguage()
    {
        return Language;
    }

    public int getCoin()
    {
        return coin;
    }

    public int getCoinpersecond()
    {
        return coinpersecond;
    }

    
    ///GET SET
    #endregion 

    public void Start()
    {
        // Load all infor
        Load();
        SetSceneHellDone(19, false);
        // Give Infor music + volume + language + Heal, Ammo, Shield, Guns, coin
        StartCoroutine(DelayOpenLevel());
    }

    //Save DATA
    public void Save()
    {
        SAVESYS.SaveDATA(this);
    }

    public void Load()
    {
        InforDATA data = SAVESYS.LoadDATA();
        this.VolumeMusic = data.VolumeMusic;
        this.VolumeSfx = data.VolumeSfx;
        this.Music = data.Music;
        this.Language = data.Language;
        this.coin = data.coin;
        this.coinpersecond = data.coinpersecond;


            this.Phong_1 = data.Phong_1;

        this.SceneHell = data.SceneHell;
        this.SceneHellDone = data.SceneHellDone;
        this.CanRun = data.CanRun;
        this.CanJump = data.CanJump;
        this.CanFly = data.CanFly;
        this.d1 = data.d1;
        this.d2 = data.d2;
        this.d3 = data.d3;
        this.d4 = data.d4;
        this.d5 = data.d5;
        this._Energy = data._Energy;

        this._LGate_1 = data._LGate_1;
        this._LGate_2 = data._LGate_2;
        this._LGate_3 = data._LGate_3;
        this.currentTime = data.currentTime;

        this.a0 = data.a0;
        this.a1 = data.a1;
        this.a2 = data.a2;
        this.a3 = data.a3;
        this.a4 = data.a4;
        this.a5 = data.a5;
        this.a6 = data.a6;

        this.ENDGAME = data.ENDGAME;

    }

    public string lv;
    public void Openlevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(lv);
    }
    //Delay Open Level
    public IEnumerator DelayOpenLevel()
    {

        yield return new WaitForSeconds(1f);
        Openlevel();

    }
}

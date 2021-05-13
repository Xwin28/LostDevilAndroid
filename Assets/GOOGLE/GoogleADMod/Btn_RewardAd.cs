using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Btn_RewardAd : MonoBehaviour
{
    
    public Collider _col;
    public GameObject _sprite;
    // Start is called before the first frame update
    void Start()
    {
        

        Debug.LogError("CHECK: " + GoogleAdsManager.instanceAds.CheckRequestReward());
        if (!GoogleAdsManager.instanceAds.CheckRequestReward())
        {
            _col.enabled = false;
            _sprite.SetActive(false);
        }
    }

    public void ShowReawrd()
    {
        GoogleAdsManager.instanceAds.ShowRewardAds();
    }
}


using UnityEngine;
using GoogleMobileAds.Api;
using System;


public class GoogleAdsManager : MonoBehaviour
{
    public static GoogleAdsManager instanceAds;

    private readonly string AppID = "ca-app-pub-3940256099942544/6300978111";
    //Videp ADS
    private InterstitialAd videoAds;
    private readonly string videoAdsID = "ca-app-pub-3940256099942544/6300978111";
    //Reward ADS
    private RewardedAd rewardedAds;
    private readonly string rewaredAdsID = "ca-app-pub-3940256099942544/5224354917";


    private void Awake()
    {

        if (instanceAds == null)
        {
            instanceAds = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
       
        // Initialize the Google Mobile Ads SDK.
        /*MobileAds.Initialize(initStatus =>
        {
            RequestVideoAds();
            RequestRewardAds();
        });*/

        MobileAds.Initialize(AppID);
        RequestVideoAds();
        RequestRewardAds();

        this.rewardedAds.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        //this.rewardedAds.OnAdClosed += HandleRewardedAdClosed;
        this.rewardedAds.OnAdOpening += HandleRewardedAdOpening;
        this.rewardedAds.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        this.rewardedAds.OnUserEarnedReward += HandleUserEarnedReward;

        /*this.videoAds.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        this.videoAds.OnAdOpening += HandleOnAdOpened;
        this.videoAds.OnAdClosed += HandleOnAdClosed;*/
        
    }


    private void RequestVideoAds()
    {
        if (this.videoAds != null)
        {
            videoAds.Destroy();
        }

        
        videoAds = new InterstitialAd(videoAdsID);
        AdRequest request = new AdRequest.Builder().Build();
        videoAds.LoadAd(request);

        if (this.videoAds.IsLoaded())
        {
            this.videoAds.OnAdFailedToLoad += HandleOnAdFailedToLoad;
            this.videoAds.OnAdOpening += HandleOnAdOpened;
            this.videoAds.OnAdClosed += HandleOnAdClosed;
        }

    }

    public void ShowVideoAds()
    {
        if (videoAds.IsLoaded())
        {
            Debug.Log("LOAD THANH CONG, SHOW VIDEO ADS");
            videoAds.Show();
        }
        else
        {
            Debug.Log("LOAD ADS THAT BAI, LOAD LAI");
            RequestVideoAds();

        }
    }
    public bool CheckRequestVideo()
    {

        if (!this.videoAds.IsLoaded())
        {
            RequestVideoAds();
        }

        if (this.videoAds.IsLoaded())
        {
            return true;
        }
        else return false;
    }
    //HANDLER VIDEOADS
    bool _doVideoOne = false;
    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        if (!_doVideoOne)
        {
            _doVideoOne = true;
            RequestVideoAds();
        }
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        _doVideoOne = true;
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Time.timeScale = 1;
        MonoBehaviour.print("HandleAdClosed event received");
    }

    //++++++++++++++++++++++++++++++++===========================
    //================================+++++++++++++++++++++++++++

    //HANDER
    bool _requestOne = false, _showOne = false;
    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        if (!_requestOne)//Chay lai request khi that bai
        {
            RequestRewardAdsHandler();
            _requestOne = true;
        }

        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        _requestOne = false;// reset de chay request khi request that bai
        _showOne = false;//reset de chay show khi show that bai
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        if (!_showOne)//Chay lai SHOW khi that bai
        {
            ShowRewardAds();
            _showOne = true;
        }
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);

    }



    public void PlusEnergy()
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player");
        _player.GetComponent<EnergyScript>().CongFullEnergy();
        
    }
    bool rewward = false;
    private void Update()
    {
        if (rewward)
        {
            rewward = false;
            PlusEnergy();
        }
    }

    // XU lY EARNEDREWARD
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        Debug.Log("NHAN TIEN REWARD");
        rewward = true;
        /*string type = args.Type;
        double amount = args.Amount;*/
        //addMoney(175);// + 175 vang
        /*MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);*/
        // RequestRewardAdsHandler();
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        //RequestRewardAdsHandler();
    }

    //Reward ADS


    public void RequestRewardAdsHandler()
    {
        if (this.rewardedAds != null)
        {
            this.rewardedAds.OnAdFailedToLoad -= HandleRewardedAdFailedToLoad;
            this.rewardedAds.OnAdClosed -= HandleRewardedAdClosed;
            this.rewardedAds.OnAdOpening -= HandleRewardedAdOpening;
            this.rewardedAds.OnAdFailedToShow -= HandleRewardedAdFailedToShow;
            this.rewardedAds.OnUserEarnedReward -= HandleUserEarnedReward;
        }

        Debug.LogError("RequestReward Hanld");
        this.rewardedAds = new RewardedAd(rewaredAdsID);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAds.LoadAd(request);

        if (this.rewardedAds != null)
        {
            this.rewardedAds.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
            this.rewardedAds.OnAdClosed += HandleRewardedAdClosed;
            this.rewardedAds.OnAdOpening += HandleRewardedAdOpening;
            this.rewardedAds.OnAdFailedToShow += HandleRewardedAdFailedToShow;
            this.rewardedAds.OnUserEarnedReward += HandleUserEarnedReward;
        }

    }
    public void RequestRewardAds()
    {
        Debug.LogError("RequestReward");
        this.rewardedAds = new RewardedAd(rewaredAdsID);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAds.LoadAd(request);
    }

    public bool CheckRequestReward()
    {
        if (!this.rewardedAds.IsLoaded())
        {
            this.RequestRewardAdsHandler();
        }


        if (this.rewardedAds.IsLoaded())
        {
            return true;
        }
        else return false;
    }

    public void ShowRewardAds()
    {
        if (this.rewardedAds.IsLoaded())
        {

            Debug.Log("LOAD THANH CONG HIEN REWARD VIDEO ADS");
            this.rewardedAds.Show();
        }

    }
}

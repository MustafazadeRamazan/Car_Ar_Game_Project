using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;

public class Reward_Ads2 : MonoBehaviour
{
    private RewardedAd rewardedAd;
    public Button reklam;
    public GameObject reklamodulupanel;
    public GameObject panel;
    public float save;

    void Start()
    {
        save = PlayerPrefs.GetFloat("savetoken");
        if (save == 1)
        {
            Destroy(panel);
            Destroy(reklamodulupanel);
        }
        else
        {
            string adUnitId;
#if UNITY_ANDROID
            adUnitId = "";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            adUnitId = "unexpected_platform";
#endif
            MobileAds.Initialize(initStatus => { });
            this.rewardedAd = new RewardedAd(adUnitId);

            // Called when an ad request has successfully loaded.
            this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
            // Called when an ad request failed to load.
            this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
            // Called when an ad is shown.
            this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
            // Called when an ad request failed to show.
            this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
            // Called when the user should be rewarded for interacting with the ad.
            this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
            // Called when the ad is closed.
            this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

            AdRequest request = new AdRequest.Builder().Build();
            this.rewardedAd.LoadAd(request);
        }
    }


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        panel.SetActive(true);
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        panel.SetActive(false);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        panel.SetActive(false);
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        reklam.interactable = true;
        string type = args.Type;
        double amount = args.Amount;
        reklamodulupanel.SetActive(true);
    }

    public void UserChoseToWatchAd()
    {
        reklam.interactable = false;
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    public void OduluAl()
    {
        save = 1;
        PlayerPrefs.SetFloat("savetoken", save);
        Destroy(reklamodulupanel);
        Destroy(panel);
    }
}

using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManager : MonoBehaviour {

  // Use this for initialization
	void Start () {

        showBannerAd();

	}

    private void showBannerAd()
    {
        string adID = "ca-app-pub-5367087138402673/9145132326";

        //***For Testing in the Device***
        AdRequest request = new AdRequest.Builder()
       .Build();

        //***For Production When Submit App***
        //AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
        bannerAd.LoadAd(request);
    }

    // Update is called once per frame
    void Update () {

	}
}

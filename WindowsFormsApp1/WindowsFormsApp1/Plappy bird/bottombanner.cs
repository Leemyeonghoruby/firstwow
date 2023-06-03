using UnityEngine;
using GoogleMobileAds.Api;
using System;
public class GoogleAdsManager : MonoBehaviour
{
    string adUnitId;
    private BannerView bannerView;
    public void Start()
    {
        // MobileAds.Initialize(initstatus => {});
        this.Requestbanner();
    }
    private void Requestbanner()
    {
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3070355756010758~3490289223";
#elif UNITY_IOS
        adUnitId = "ca-app-pub-3940256099942544~1458002511";
#else
        adUnitId = "unexpected_platform ;
#endif
        // Create a 320¡¿50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
}
    // update is called once a frame

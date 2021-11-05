using UnityEngine;
using GoogleMobileAds.Api;
using System.Collections;

public class BannerAd : MonoBehaviour
{
    private BannerView _bannerView;

    private string _bannerUnitId = "ca-app-pub-3839680777472291/7107444260";

    private void OnEnable()
    {
        _bannerView = new BannerView(_bannerUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest adRequest = new AdRequest.Builder().Build();
        _bannerView.LoadAd(adRequest);
        StartCoroutine(ShowBanner());
    }

    IEnumerator ShowBanner()
    {
        yield return new WaitForSecondsRealtime(3f);
        _bannerView.Show();

    }
}

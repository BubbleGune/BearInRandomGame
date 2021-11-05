using UnityEngine;
using GoogleMobileAds.Api;

class AdMobeInitialize : MonoBehaviour
{
    private void Awake()
    {
        MobileAds.Initialize(InitializationStatus => { });
    }
}


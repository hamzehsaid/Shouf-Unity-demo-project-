using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class AdsScriptTwo : MonoBehaviour
{

	// Use this for initialization

	//public Button finishAds;
	//public Button finishAdst;
	BannerView bannerAd;
	void Start()
	{

		int noads = PlayerPrefs.GetInt("nads");
		if (noads != 1)
		{
			//	finishAds.gameObject.SetActive (true);
			//finishAdst.gameObject.SetActive (true);
			showBannerAd();
		}
	}

	// spruce id ca-app-pub-9437415255143113/2042268588

	private void showBannerAd()
	{
		string adID = "ca-app-pub-9437415255143113/8076428235";



		//test id ca-app-pub-3940256099942544/2934735716

		//**For Testing in the Device**
		/*AdRequest request = new AdRequest.Builder()
			.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
			.AddTestDevice("33BE2250B43518CCDA7DE426D04EE232")  // My test device.
			.Build();*/

		//**For Production When Submit App**
		AdRequest request = new AdRequest.Builder().Build();

		bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
		bannerAd.LoadAd(request);
	}
	public void HideAds()
	{


		bannerAd.Hide();

	}


}
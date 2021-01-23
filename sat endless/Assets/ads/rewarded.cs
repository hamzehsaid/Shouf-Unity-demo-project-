using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using System;


public class rewarded : MonoBehaviour {




    // final text id ca-app-pub-3940256099942544/1712485313
	private RewardBasedVideoAd rewardBasedVideo;


   

    bool rewardAnim;
    bool rewardDiamond;
	

	void Awake(){
		//InitializeRewarded ();
		RequestRewardedVideo ();
		// Get singleton reward based video ad reference.


	

		//this.RequestRewardedVideo();

	
	}

	//test ca-app-pub-3940256099942544/1712485313



  

    //real  gardenside ca-app-pub-9437415255143113/6801272959

	/*private void InitializeRewarded(){
		#if UNITY_ANDROID
		string appId = "";
		#elif UNITY_IPHONE
		string appId = "ca-app-pub-9437415255143113~4026462815";
		#else
		string appId = "unexpected_platform";
		#endif

		MobileAds.Initialize (appId);


	
	
	
	}*/


    // spruce id rewarded ca-app-pub-9437415255143113/2658234301.

	private void RequestRewardedVideo()
	{
		#if UNITY_ANDROID
		string adUnitId = " ";
		#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-9437415255143113/6801272959";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		rewardBasedVideo = RewardBasedVideoAd.Instance;



		// Called when an ad request has successfully loaded.
		rewardBasedVideo.OnAdLoaded += HandleRewardBasedVideoLoaded;
		// Called when an ad request failed to load.
		rewardBasedVideo.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
		// Called when an ad is shown.
		rewardBasedVideo.OnAdOpening += HandleRewardBasedVideoOpened;
		// Called when the ad starts to play.
		rewardBasedVideo.OnAdStarted += HandleRewardBasedVideoStarted;
		// Called when the user should be rewarded for watching a video.
		rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
		// Called when the ad is closed.
		rewardBasedVideo.OnAdClosed += HandleRewardBasedVideoClosed;
		// Called when the ad click caused the user to leave the application.
		rewardBasedVideo.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;
		//test id ca-app-pub-3940256099942544/1712485313

        //real id ca-app-pub-9437415255143113/2689125791
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the rewarded video ad with the request.
		rewardBasedVideo.LoadAd(request, adUnitId);
	}



    public void showVideodiamond(){


        rewardDiamond = true;
            String adUnitId = "ca-app-pub-9437415255143113/6801272959";
            if (rewardBasedVideo.IsLoaded())
            {
                //Subscribe to Ad event
                //rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
                rewardBasedVideo.Show();
            }
            else
            {

                AdRequest request = new AdRequest.Builder().Build();
                rewardBasedVideo.LoadAd(request, adUnitId);
            }



    }





	public void showVideoReward(){

		/*if (rewardBasedVideo.IsLoaded ()) {
				rewardBasedVideo.Show ();
				//Debug.Log ("done");
			} else {
				//Debug.Log ("heh");
			}*/
		int noads = PlayerPrefs.GetInt("nads");
		if (noads != 1)
		{
			rewardAnim = true;
			String adUnitId = "ca-app-pub-9437415255143113/6801272959";
			if (rewardBasedVideo.IsLoaded())
			{
				//Subscribe to Ad event
				//rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
				rewardBasedVideo.Show();
			}
			else
			{

				AdRequest request = new AdRequest.Builder().Build();
				rewardBasedVideo.LoadAd(request, adUnitId);
			}
		}

	}

	public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
	{
       

			
		

	}

	public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{	
		/*String adUnitId = "ca-app-pub-3940256099942544/1712485313";
		AdRequest request = new AdRequest.Builder().Build();
		rewardBasedVideo.LoadAd(request, adUnitId);*/
		//RequestRewardedVideo ();
		

	}

	public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
	{
		
	}

	public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
	{
		
	}

	public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
	{
     

	}

	public void HandleRewardBasedVideoRewarded(object sender, Reward args)
	{

        if(rewardAnim == true){


            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 70);
            rewardAnim = false;
        }

        if(rewardDiamond == true){

            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") + 1);
            rewardDiamond = false;


        }

    

	}

	public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
	{
       
	}


  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallAndroid : MonoBehaviour {

	AndroidJavaClass androidjavaClass;
	AndroidJavaObject androidjavaObj;

	// Use this for initialization
	void Start () {
		androidjavaClass = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		androidjavaObj = androidjavaClass.GetStatic<AndroidJavaObject> ("currentActivity");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void callToast(){
		if(null != androidjavaObj){
			androidjavaObj.Call ("showToast");
		}
	}

	public void callToast2(){
		if(null != androidjavaObj){
			androidjavaObj.Call ("showToast","unity3d Str");
		}
	}

	public void callAndroidStr(){
		if(null != androidjavaObj){
			string rlt = androidjavaObj.Call<string> ("getAndroidStr");
			gameObject.GetComponentInChildren<Text>().text = rlt;
		}
	}

}

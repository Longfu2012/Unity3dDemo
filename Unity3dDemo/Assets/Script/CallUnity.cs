using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallUnity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeObj1(){
		gameObject.GetComponentInChildren<Text>().text = "android调用 无参方法";
	}

	public void ChangeObj2(string str){
		gameObject.GetComponentInChildren<Text>().text = "android调用 有参方法 参数:" + ((str == null ) ? "get null ?":str);
	}

}
